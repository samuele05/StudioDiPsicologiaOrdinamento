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
    public partial class AggiuntaMedico : Form
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

        public static AggiuntaMedico instance;
        public AggiuntaMedico()
        {
            instance = this;
            InitializeComponent();
        }



        // ----------------------------------------------------------------------------------------------------



        // form load
        private void AggiuntaMedico_Load(object sender, EventArgs e)
        {
            // bottoni
            btnAggiungiMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiMedico.Width, btnAggiungiMedico.Height, 10, 10));
        }

        // medico
        Medico medico = new Medico();


        // bottone aggiungi medico
        private void btnAggiungiMedico_Click(object sender, EventArgs e)
        {
            if (inizializzaMedico())
            {
                if (scriviMed())
                {
                    // ordina => test
                    Form1.instance.ordinaArchivioMedici();

                    // ricarica medici
                    Form1.instance.caricaMedici();
                    Form1.instance.caricaCbMedici();
                    Form1.instance.caricaCbListaMedici();

                    MessageBox.Show("Aggiunto", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Esiste già o non è stao inserito nulla", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
            else
                MessageBox.Show("Inserire dei campi validi", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        int apertura = Form1.instance.apertura;
        int chiusura = Form1.instance.chiusura;


        // inizializza medico
        public bool inizializzaMedico()
        {
            if (tbNomeMedico.Text == "" || tbCognomeMedico.Text == "" || tbSpecializzazioneMedico.Text == "")
                return false;

            medico._nome = tbNomeMedico.Text;
            medico._cognome = tbCognomeMedico.Text;
            medico._specializzazione = tbSpecializzazioneMedico.Text;
            medico._inCarica = true;

            int inizio = Convert.ToInt32(nudInizioOrario.Value);
            int fine = Convert.ToInt32(nudFineOrario.Value);

            if (inizio >= apertura && inizio < chiusura && fine > apertura && fine <= chiusura)
            {
                if (inizio < fine)
                {
                    medico._inizioOrario = inizio;
                    medico._fineOrario = fine;
                    return true;
                }
            }
            return false;
        }


        // funzione scrivi medico
        public bool scriviMed()
        {
            if (!esiste(medico))
            {
                medico.scriviMedico();
                return true;
            }
            return false;
        }


        // funzione esiste
        private bool esiste(Medico med)
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                fs.Seek(med.getByte() - med.lunghezzaCodice(), SeekOrigin.Current);       // 72 byte tra un codice e l'altro (specificato nella classe medico)
                string codiceLetto = leggi.ReadString();

                if (codiceLetto == med.getCodice())
                {
                    fs.Close();
                    return true;
                }
            }
            fs.Close();
            return false;
        }



        // ----------------------------------------------------------------------------------------------------



        // limitazioni textbox
        private void tbNomeMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void tbCognomeMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void tbSpecializzazioneMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
    }
}
