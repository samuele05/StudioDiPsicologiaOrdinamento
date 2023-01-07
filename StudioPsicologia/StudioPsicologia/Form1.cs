using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace StudioPsicologia
{
    public partial class Form1 : Form
    {
        // Angoli arrotondati
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        // Sposta Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public static Form1 instance;
        public Form1()
        {
            instance = this;
            InitializeComponent();
        }



        // ----------------------------------------------------------------------------------------------------



        private void Form1_Load(object sender, EventArgs e)
        {
            // bottoni
            btnAggiungiPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiPaziente.Width, btnAggiungiPaziente.Height, 10, 10));
            btnAggiungiMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiMedico.Width, btnAggiungiMedico.Height, 10, 10));
            btnRimuoviMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviMedico.Width, btnRimuoviMedico.Height, 10, 10));
            btnAggiungiAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiAppuntamento.Width, btnAggiungiAppuntamento.Height, 10, 10));
            btnRimuoviAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviAppuntamento.Width, btnRimuoviAppuntamento.Height, 10, 10));
            btnRimuoviPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviPaziente.Width, btnRimuoviPaziente.Height, 10, 10));
            btnModificaAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModificaAppuntamento.Width, btnModificaAppuntamento.Height, 10, 10));
            btnSeleziona.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSeleziona.Width, btnSeleziona.Height, 10, 10));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));

            // pannelli
            plInformazioniAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plInformazioniAppuntamento.Width, plInformazioniAppuntamento.Height, 10, 10));
            plAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plAppuntamento.Width, plAppuntamento.Height, 10, 10));
            plArgomento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plArgomento.Width, plArgomento.Height, 10, 10));
            plSelezionaAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plSelezionaAppuntamento.Width, plSelezionaAppuntamento.Height, 10, 10));
            plInfoMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plInfoMedico.Width, plInfoMedico.Height, 10, 10));
            plInfoPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plInfoPaziente.Width, plInfoPaziente.Height, 10, 10));

            // funzione start
            start();
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------

        // liste
        List<Medico> medici = new List<Medico>();
        List<Paziente> pazienti = new List<Paziente>();

        public int apertura = 8;
        public int chiusura = 18;

        Studio studio = new Studio();

        // def orari 
        public void definisciOrariStudio()
        {
            studio._orarioApertura = apertura;
            studio._orarioChiusura = chiusura;
        }


        // funzione start
        public void start()
        {
            // ordina => test
            ordinaArchivioMedici();
            ordinaArchivioPazienti();

            // carica pazienti
            caricaPazienti();
            caricaCbPazienti();

            // carica medici
            caricaMedici();
            caricaCbMedici();

            // studio
            definisciOrariStudio();
            caricaAppuntamenti();

            // carica combobox appuntamenti
            caricaCbAppuntamenti();

            // svuota label info appuntamento
            svuotaLabelInfoAppuntamento();
            svuotaLabelInfoMedico();
            svuotaLabelInfoPaziente();

            // carica combobox CbListaMedici/Pazienti
            caricaCbListaMedici();
            caricaCbListaPazienti();

            // selseziona la tab appuntamenti
            tcPagine.SelectedIndex = 2;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione cerca medico
        private Medico cercaMedico(string codiceMedico)
        {
            Medico med = new Medico();
            for (int i = 0; i < medici.Count; i++)
                if (medici[i].getCodice() == codiceMedico)
                    med = medici[i];
            return med;
        }

        // funzione cerca paziente
        private Paziente cercaPaziente(string codicePaziente)
        {
            Paziente paz = new Paziente();
            for (int i = 0; i < pazienti.Count; i++)
                if (pazienti[i].getCodice() == codicePaziente)
                    paz = pazienti[i];
            return paz;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione carica medici da file    <--  cerca il codice nell'archivio e prende il medico dal file
        public void caricaMedici()
        {
            medici.Clear();

            FileStream fs = new FileStream("archivioMedici.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            FileStream fs1 = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryReader leggi1 = new BinaryReader(fs1);

            fs.Seek(0, SeekOrigin.Begin);

            while (fs.Position < fs.Length)
            {
                string codice = leggi.ReadString();
                int posizione = leggi.ReadInt32();

                // cerco il medico alla posizione
                fs1.Seek(posizione, SeekOrigin.Begin);

                Medico med = new Medico();
                med._nome = leggi1.ReadString().Trim(' ');
                med._cognome = leggi1.ReadString().Trim(' ');
                med._specializzazione = leggi1.ReadString().Trim(' ');
                med._inCarica = leggi1.ReadBoolean();
                med._inizioOrario = leggi1.ReadInt32();
                med._fineOrario = leggi1.ReadInt32();

                fs1.Seek(11, SeekOrigin.Current);
                medici.Add(med);
            }
            fs1.Close();
            fs.Close();
        }

        // funzione carica pazienti da file   <--  cerca il codice nell'archivio e prende il paziente dal file
        public void caricaPazienti()
        {
            pazienti.Clear();

            FileStream fs = new FileStream("archivioPazienti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            FileStream fs1 = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi1 = new BinaryReader(fs1);

            fs.Seek(0, SeekOrigin.Begin);

            while (fs.Position < fs.Length)
            {
                string codice = leggi.ReadString();
                int posizione = leggi.ReadInt32();

                // cerco il paziente alla posizione
                fs1.Seek(posizione, SeekOrigin.Begin);

                Paziente paz = new Paziente();
                paz._nome = leggi1.ReadString().Trim(' ');
                paz._cognome = leggi1.ReadString().Trim(' ');
                paz._giornoNascita = leggi1.ReadInt32();
                paz._meseNascita = leggi1.ReadInt32();
                paz._annoNascita = leggi1.ReadInt32();
                paz._IBAN = leggi1.ReadString();

                pazienti.Add(paz);
            }
            fs1.Close();
            fs.Close();
        }

        // funzione carica appuntamenti da file
        public void caricaAppuntamenti()
        {
            FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Appuntamento app = new Appuntamento();
                app._medico = cercaMedico(leggi.ReadString());
                app._paziente = cercaPaziente(leggi.ReadString());
                app._data = leggi.ReadString();
                app._argomento = leggi.ReadString();
                app._orario = leggi.ReadInt32();
                app._concluso = leggi.ReadBoolean();

                fs.Seek(50 + 1, SeekOrigin.Current);
                studio.aggiungiAppuntamento(app);
            }
            fs.Close();
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione carica medici nella cbListaMedici
        public void caricaCbListaMedici()
        {
            cbListaMedici.Items.Clear();
            for (int i = 0; i < medici.Count; i++)
                cbListaMedici.Items.Add($"{medici[i]._nome} {medici[i]._cognome} {medici[i].getCodice()}");
        }

        // funzione carica pazienti nella cbListaPazienti
        public void caricaCbListaPazienti()
        {
            cbListaPazienti.Items.Clear();
            for (int i = 0; i < pazienti.Count; i++)
                cbListaPazienti.Items.Add($"{pazienti[i]._nome} {pazienti[i]._cognome} {pazienti[i].getCodice()}");
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione carica pazienti nella combobox
        public void caricaCbPazienti()
        {
            cbPazienti.Items.Clear();
            for (int i = 0; i < pazienti.Count; i++)
                cbPazienti.Items.Add($"{pazienti[i]._nome} {pazienti[i]._cognome} {pazienti[i].getCodice()}");
        }

        // funzione carica medici nella combobox
        public void caricaCbMedici()
        {
            cbMedici.Items.Clear();
            for (int i = 0; i < medici.Count; i++)
                if (medici[i]._inCarica)    // carica solo i medici in carica
                    cbMedici.Items.Add($"{medici[i]._nome} {medici[i]._cognome} {medici[i].getCodice()}");
        }

        // funzione carica appuntamenti nella combobox
        public void caricaCbAppuntamenti()
        {
            studio._appuntamenti.Sort();

            cbAppuntamenti.Items.Clear();
            for (int i = 0; i < studio._appuntamenti.Count; i++)
                if (studio._appuntamenti[i]._data == dtpAppuntamenti.Text)
                    if (!(studio._appuntamenti[i]._concluso))
                        cbAppuntamenti.Items.Add(/*$"medico: {studio._appuntamenti[i]._medico._cognome} |" +
                        $" paziente: {studio._appuntamenti[i]._paziente._cognome} {studio._appuntamenti[i]._paziente._nome} |" + */
                        $" ora: {studio._appuntamenti[i]._orario} |" +
                        $" codice: {studio._appuntamenti[i].codiceAppuntamento()}");
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione carica informazioni appuntamento
        public void caricaInfoAppuntamento()
        {
            for (int i = 0; i < studio._appuntamenti.Count; i++)
            {
                if (cbAppuntamenti.Text != "")
                {
                    string codice = cbAppuntamenti.Text.Split(' ')[5];
                    if (codice == studio._appuntamenti[i].codiceAppuntamento())
                    {
                        lblMedicoAppuntamento.Text = studio._appuntamenti[i]._medico.ToString();
                        lblPazienteAppuntamento.Text = studio._appuntamenti[i]._paziente.ToString();
                        lblDataAppuntamento.Text = studio._appuntamenti[i]._data;
                        lblOrarioAppuntamento.Text = studio._appuntamenti[i]._orario.ToString();
                        tbArgomentoInfoAppuntamento.Text = studio._appuntamenti[i]._argomento;
                    }
                }
            }
        }

        // funzione libera label info appuntamento
        public void svuotaLabelInfoAppuntamento()
        {
            lblMedicoAppuntamento.Text = "-";
            lblPazienteAppuntamento.Text = "-";
            lblDataAppuntamento.Text = "-";
            lblOrarioAppuntamento.Text = "-";
            tbArgomentoInfoAppuntamento.Text = "";
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione carica informazioni medico
        public void caricaInfoMedico()
        {
            for (int i = 0; i < medici.Count; i++)
            {
                if (cbListaMedici.Text != "")
                {
                    string codice = cbListaMedici.Text.Split(' ')[2];
                    if (codice == medici[i].getCodice())
                    {
                        lblNomeMedico.Text = medici[i]._nome;
                        lblCognomeMedico.Text = medici[i]._cognome;
                        lblSpecializzazioneMedico.Text = medici[i]._specializzazione;
                        lblOrarioMedico.Text = $"{medici[i]._inizioOrario} - {medici[i]._fineOrario}";
                        if (medici[i]._inCarica)
                            lblInCaricaMedico.Text = "lavora";
                        else
                            lblInCaricaMedico.Text = "non lavora";
                    }
                }
            }
        }

        // funzione libera label info medico
        public void svuotaLabelInfoMedico()
        {
            lblNomeMedico.Text = "-";
            lblCognomeMedico.Text = "-";
            lblSpecializzazioneMedico.Text = "-";
            lblOrarioMedico.Text = "-";
            lblInCaricaMedico.Text = "-";
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione carica informazioni paziente
        public void caricaInfoPaziente()
        {
            for (int i = 0; i < pazienti.Count; i++)
            {
                if (cbListaPazienti.Text != "")
                {
                    string codice = cbListaPazienti.Text.Split(' ')[2];
                    if (codice == pazienti[i].getCodice())
                    {
                        lblNomePaziente.Text = pazienti[i]._nome;
                        lblCognomePaziente.Text = pazienti[i]._cognome;
                        lblDataDiNascitaPaziente.Text = $"{pazienti[i]._giornoNascita}/{pazienti[i]._meseNascita}/{pazienti[i]._annoNascita}";
                        lblIBANPaziente.Text = pazienti[i]._IBAN;
                    }
                }
            }
        }

        // funzione libera label info paziente
        public void svuotaLabelInfoPaziente()
        {
            lblNomePaziente.Text = "-";
            lblCognomePaziente.Text = "-";
            lblDataDiNascitaPaziente.Text = "-";
            lblIBANPaziente.Text = "-";
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // bottone aggiungi appuntamento
        private void btnAggiungiAppuntamento_Click(object sender, EventArgs e)
        {
            if (cbPazienti.Text != "" && cbMedici.Text != "")
            {
                if (!appEsiste())
                {
                    if (controllaOrario())
                    {
                        if (aggiungiAppuntamento())
                        {
                            caricaCbAppuntamenti();
                            MessageBox.Show("Appuntamento aggiunto", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else 
                            MessageBox.Show("Questo medico non è disponibile", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("L'orario non esiste", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }      
                else
                    MessageBox.Show("L'orario è occupato", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Tutti i campi non sono stati inseriti", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // aggiorna gli appuntamenti una volta agiunti
            caricaCbAppuntamenti();
        }

        // bottone rimuovi appuntamento
        private void btnRimuoviAppuntamento_Click(object sender, EventArgs e)
        {
            if (cbAppuntamenti.Text != "")
            {
                string codice = cbAppuntamenti.Text.Split(' ')[5];
                if (rimuoviAppuntamento(codice))
                {
                    caricaCbAppuntamenti();
                    MessageBox.Show("Rimosso", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    svuotaLabelInfoAppuntamento();
                }
                else
                    MessageBox.Show("L'appuntamento non esiste", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Inserire tutti i campi", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione rimuovi appuntamento
        public bool rimuoviAppuntamento(string codiceAppuntameneto)
        {
            Appuntamento app = new Appuntamento();
            FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                fs.Seek(app.getByte() - app.lunghezzaCodice(), SeekOrigin.Current);
                string codiceLetto = leggi.ReadString();

                if (codiceLetto == codiceAppuntameneto)
                {
                    fs.Seek(-(app.getByte()), SeekOrigin.Current);

                    for (int i = 0; i < studio._appuntamenti.Count; i++)
                        if (studio._appuntamenti[i].codiceAppuntamento() == codiceAppuntameneto)
                        {
                            studio._appuntamenti[i]._concluso = true;
                            studio._appuntamenti[i].scriviApp(scrivi);
                        }

                    fs.Close();
                    return true;
                }
            }
            fs.Close();
            return false;
        }

        // funzione esiste appuntamento
        public bool appEsiste()
        {
            int orario = 0;
            if (cbOrariLiberi.Text != "") 
                orario = Convert.ToInt32(cbOrariLiberi.Text);

            for (int i = 0; i < studio._appuntamenti.Count; i++)
                if (studio._appuntamenti[i]._data == dtpDataAppuntamento.Text)
                    if (studio._appuntamenti[i]._orario == orario)
                        if (!(studio._appuntamenti[i]._concluso))
                            return true;
            return false;
        }

        // funzione inizializza e scrivi appuntamento
        private bool aggiungiAppuntamento()
        {
            Appuntamento app = new Appuntamento();
            string codicePaziente = cbPazienti.SelectedItem.ToString().Split(' ')[2];
            string codiceMedico = cbMedici.SelectedItem.ToString().Split(' ')[2];

            // definisci paziente
            for (int i = 0; i < pazienti.Count; i++)
                if (pazienti[i].getCodice() == codicePaziente)
                    app._paziente = pazienti[i];

            // definisci medico
            for (int i = 0; i < medici.Count; i++)
                if (medici[i].getCodice() == codiceMedico)
                    app._medico = medici[i];

            // definisci data
            app._data = dtpDataAppuntamento.Text;

            // definisci orario
            int orario = 0;
            if (cbOrariLiberi.Text != "")
                orario = Convert.ToInt32(cbOrariLiberi.Text);
            if (!(orario >= app._medico._inizioOrario && orario < app._medico._fineOrario))
                return false;

            app._orario = orario;
            app._argomento = tbArgomentoAppuntamento.Text;
            app._concluso = false;

            // aggiungi appuntamento
            studio.aggiungiAppuntamento(app);
            app.scriviAppuntemento();

            return true;
        }

        // funzione inizializza e scrivi appuntamento
        private Appuntamento definisciAppuntamentoModificato(int ora)
        {
            Appuntamento app = new Appuntamento();
            string codicePaziente = cbPazienti.SelectedItem.ToString().Split(' ')[2];
            string codiceMedico = cbMedici.SelectedItem.ToString().Split(' ')[2];

            // definisci paziente
            for (int i = 0; i < pazienti.Count; i++)
                if (pazienti[i].getCodice() == codicePaziente)
                    app._paziente = pazienti[i];

            // definisci medico
            for (int i = 0; i < medici.Count; i++)
                if (medici[i].getCodice() == codiceMedico)
                    app._medico = medici[i];

            app._data = dtpDataAppuntamento.Text;
            app._orario = ora;
            app._argomento = tbArgomentoAppuntamento.Text;
            app._concluso = false;

            return app;
        }

        // definisci appuntamento
        Appuntamento appuntamento = new Appuntamento();
        int orarioAppo = 0;

        // funzione modifica appuntamento
        public bool modificaAppuntamento()
        {
            if (cbAppuntamenti.Text != "")
            {
                string codice = cbAppuntamenti.Text.Split(' ')[5];
                for (int i = 0; i < studio._appuntamenti.Count; i++)
                {
                    if (studio._appuntamenti[i].codiceAppuntamento() == codice)
                    {
                        // seleziona medico
                        int medicoIndex = 0;
                        for (int k = 0; k < cbMedici.Items.Count; k++)
                        {
                            cbMedici.SelectedIndex = k;
                            if (cbMedici.Text == $"{studio._appuntamenti[i]._medico._nome} {studio._appuntamenti[i]._medico._cognome} {studio._appuntamenti[i]._medico.getCodice()}")
                                medicoIndex = k;
                        }
                        cbMedici.SelectedIndex = medicoIndex;

                        // seleziona paziente
                        int pazienteIndex = 0;
                        for (int k = 0; k < cbPazienti.Items.Count; k++)
                        {
                            cbPazienti.SelectedIndex = k;
                            if (cbPazienti.Text == $"{studio._appuntamenti[i]._paziente._nome} {studio._appuntamenti[i]._paziente._cognome} {studio._appuntamenti[i]._paziente.getCodice()}")
                                pazienteIndex = k;
                        }
                        cbPazienti.SelectedIndex = pazienteIndex;

                        // seleziona argomento
                        tbArgomentoAppuntamento.Text = studio._appuntamenti[i]._argomento;

                        // seleziona data
                        dtpDataAppuntamento.Text = studio._appuntamenti[i]._data;
                    }
                }
            }
            return true;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // controlla orario
        public bool controllaOrario()
        {
            int orario = 0;
            if (cbOrariLiberi.Text != "")
                orario = Convert.ToInt32(cbOrariLiberi.Text);

            if (orario >= apertura && orario < chiusura)
                return true;
            return false;
        }

        // funzione orari liberi
        public void orariLiberi()
        {
            cbOrariLiberi.Items.Clear();
            List<int> lista = new List<int>();

            int inizioOrario = 0;
            int fineOrario = 0;
            if (cbMedici.Text != "")
            {
                inizioOrario = cercaMedico(cbMedici.Text.Split(' ')[2])._inizioOrario;
                fineOrario = cercaMedico(cbMedici.Text.Split(' ')[2])._fineOrario;
            }

            for (int i = 0; i < chiusura - apertura; i++)
                lista.Add(i + 8);

            for (int i = 0; i < studio._appuntamenti.Count; i++)
                if (studio._appuntamenti[i]._data == dtpDataAppuntamento.Text)
                    lista.Remove(studio._appuntamenti[i]._orario);

            for (int i = 0; i < lista.Count; i++)
                if (lista[i] >= inizioOrario && lista[i] < fineOrario)
                    cbOrariLiberi.Items.Add(lista[i]);
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // bottone salva modifiche
        private void button1_Click(object sender, EventArgs e)
        {
            Appuntamento app = new Appuntamento();
            FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);
            BinaryWriter scrivi = new BinaryWriter(fs);

            if (cbAppuntamenti.Text != "")
            {
                string codice = cbAppuntamenti.Text.Split(' ')[5];

                while (fs.Position < fs.Length)
                {
                    fs.Seek(app.getByte() - app.lunghezzaCodice(), SeekOrigin.Current);
                    string codiceLetto = leggi.ReadString();

                    if (codiceLetto == codice)
                    {
                        fs.Seek(-(app.getByte()), SeekOrigin.Current);

                        // definisci orario
                        if (cbOrarioCorrente.Checked)
                            orarioAppo = Convert.ToInt32(lblOrarioAppuntamento.Text);
                        else
                        {
                            if (cbOrariLiberi.Text != "")
                                orarioAppo = Convert.ToInt32(cbOrariLiberi.Text);
                            else
                            {
                                MessageBox.Show("Inserire l'orario o confermare quello corrente", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }     
                        }

                        // definisci appuntamento
                        appuntamento = definisciAppuntamentoModificato(orarioAppo);
                        
                        // scrivi appuntamento
                        appuntamento.scriviApp(scrivi);

                        // modifiche salvate
                        MessageBox.Show("Modifiche salvate", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            fs.Close();

            // aggiorna appuntamenti
            studio._appuntamenti.Clear();
            caricaAppuntamenti();
            caricaCbAppuntamenti();
            svuotaLabelInfoAppuntamento();
        }


        // bottone modifica appuntamento
        private void btnModificaAppuntamento_Click(object sender, EventArgs e)
        {
            modificaAppuntamento();
        }


        // bottone rimuovi paziente
        private void btnRimuoviPaziente_Click(object sender, EventArgs e)
        {
            RimuoviPaziente rimuoviPaziente = new RimuoviPaziente();
            rimuoviPaziente.ShowDialog();
        }

        // bottone rimuovi medico
        private void btnRimuoviMedico_Click(object sender, EventArgs e)
        {
            RimuoviMedico rimuoviMedico = new RimuoviMedico();
            rimuoviMedico.ShowDialog();
        }

        // bottone seleziona data
        private void btnSeleziona_Click(object sender, EventArgs e)
        {
            caricaCbAppuntamenti();
        }



        //--------------------------------------------------------------------------------------------------------------------------------------------



        // limitazioni textbox
        private void btnAggiungiPaziente_Click(object sender, EventArgs e)
        {
            AggiuntaPaziente aggiuntaPaziente = new AggiuntaPaziente();
            aggiuntaPaziente.ShowDialog();
        }
        private void btnAggiungiMedico_Click(object sender, EventArgs e)
        {
            AggiuntaMedico aggiuntaMedico = new AggiuntaMedico();
            aggiuntaMedico.ShowDialog();
        }

        // appoggio per verificare se la data o il medico sono cambiati
        string dataTest = "";
        string medicoTest = "";

        // timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            caricaInfoAppuntamento();
            if (dtpDataAppuntamento.Text != dataTest || cbMedici.Text != medicoTest)
            {
                orariLiberi();
                dataTest = dtpDataAppuntamento.Text;
                medicoTest = cbMedici.Text;
            }

            // aggiorna info medico
            caricaInfoMedico();
            caricaInfoPaziente();
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------



        // struct persona
        struct PersPos //: IComparable<PersPos>
        {
            public string codice;
            public int posizione;
            //public int CompareTo(PersPos other) => this.codice.CompareTo(other.codice);

            public void scriviPers(BinaryWriter scrivi)
            {
                scrivi.Write(codice);
                scrivi.Write(posizione);
            }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione ordina medici in archivioMedici (ordinamento per codice)
        public void ordinaArchivioMedici()
        {
            FileStream fs = new FileStream("archivioMedici.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);
            BinaryWriter scrivi = new BinaryWriter(fs);
            fs.Seek(0, SeekOrigin.Begin);

            long posizione1;
            for (long i = 0; i < fs.Length; i = posizione1)
            {
                fs.Seek(i, SeekOrigin.Begin);

                PersPos medico1;
                medico1.codice = leggi.ReadString();
                medico1.posizione = leggi.ReadInt32();
                posizione1 = fs.Position;

                long posizione2;
                for (long j = 0; j < fs.Length; j = posizione2)
                {
                    fs.Seek(j, SeekOrigin.Begin);

                    PersPos medico2;
                    medico2.codice = leggi.ReadString();
                    medico2.posizione = leggi.ReadInt32();
                    posizione2 = fs.Position;

                    if (medico1.codice.CompareTo(medico2.codice) < 0)
                    {
                        fs.Seek(j, SeekOrigin.Begin);
                        medico1.scriviPers(scrivi);

                        fs.Seek(i, SeekOrigin.Begin);
                        medico2.scriviPers(scrivi);

                        medico1 = medico2;
                    }
                }
            }
            fs.Close();
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


        // funzione ordina medici in archivioPazienti (ordinamento per iban)
        public void ordinaArchivioPazienti()
        {
            FileStream fs = new FileStream("archivioPazienti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);
            BinaryWriter scrivi = new BinaryWriter(fs);
            fs.Seek(0, SeekOrigin.Begin);

            long posizione1;
            for (long i = 0; i < fs.Length; i = posizione1)
            {
                fs.Seek(i, SeekOrigin.Begin);

                PersPos paziente1;
                paziente1.codice = leggi.ReadString();
                paziente1.posizione = leggi.ReadInt32();
                posizione1 = fs.Position;

                long posizione2;
                for (long j = 0; j < fs.Length; j = posizione2)
                {
                    fs.Seek(j, SeekOrigin.Begin);

                    PersPos paziente2;
                    paziente2.codice = leggi.ReadString();
                    paziente2.posizione = leggi.ReadInt32();
                    posizione2 = fs.Position;

                    if (paziente1.codice.CompareTo(paziente2.codice) < 0)
                    {
                        fs.Seek(j, SeekOrigin.Begin);
                        paziente1.scriviPers(scrivi);

                        fs.Seek(i, SeekOrigin.Begin);
                        paziente2.scriviPers(scrivi);

                        paziente1 = paziente2;
                    }
                }
            }
            fs.Close();
        }
    }
}
