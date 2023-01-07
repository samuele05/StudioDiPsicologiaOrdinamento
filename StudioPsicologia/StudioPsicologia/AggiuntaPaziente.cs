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
    public partial class AggiuntaPaziente : Form
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

        public static AggiuntaPaziente instance;
        public AggiuntaPaziente()
        {
            InitializeComponent();
            instance = this;
        }



        // ----------------------------------------------------------------------------------------------------



        private void AggiuntaPaziente_Load(object sender, EventArgs e)
        {
            // bottoni
            btnAggiungiPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiPaziente.Width, btnAggiungiPaziente.Height, 10, 10));
        }


        Paziente paziente = new Paziente();
        int giornoDiNascita;
        int meseDiNascita;
        int annoDiNascita;


        // bottone aggiungi paziente
        private void btnAggiungiPaziente_Click(object sender, EventArgs e)
        {
            if (inizializzaPaziente())
            {
                if (scriviPaz())
                {
                    // ordina => test
                    Form1.instance.ordinaArchivioPazienti();

                    // ricarica pazienti
                    Form1.instance.caricaPazienti();
                    Form1.instance.caricaCbPazienti();
                    Form1.instance.caricaCbListaPazienti();

                    MessageBox.Show("Aggiunto", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Esiste già o tutti i campi non sono stati inseriti", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Inserire dei campi validi", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        

        // funzione inizializza paziente
        public bool inizializzaPaziente()
        {
            // verifica che tutti i campi sono stati inseriti
            if (tbNomePaziente.Text == "" || tbCognomePaziente.Text == "" || tbIAggiungiIBAN.Text == "")
                return false;

            // definiscilo
            paziente._nome = tbNomePaziente.Text;
            paziente._cognome = tbCognomePaziente.Text;
            data();
            paziente._giornoNascita = giornoDiNascita;
            paziente._meseNascita = meseDiNascita;
            paziente._annoNascita = annoDiNascita;

            // verifica che l'iban sia di 27 caratteri
            if (tbIAggiungiIBAN.Text.Length != 27)
                return false;

            paziente._IBAN = tbIAggiungiIBAN.Text.ToUpper();

            return true;
        }


        // funzione scrivi paziente
        public bool scriviPaz()
        {
            if (!esiste(paziente))
            {
                paziente.scriviPaziente();
                return true;
            }
            return false;
        }


        // funzione esiste
        private bool esiste(Paziente paz)
        {
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                fs.Seek(paz.getByte() - paz.lunghezzaCodice(), SeekOrigin.Current);          // 54 byte tra un IBAN e l'altro (specificato nella classe paziente)
                string codiceLetto = leggi.ReadString();

                if (codiceLetto == paz.getCodice())
                {
                    fs.Close();
                    return true;
                }
            }
            fs.Close();
            return false;
        }


        // funzione data
        public void data()
        {
            DateTime data = dtpNascitaPaziente.Value;
            giornoDiNascita = data.Date.Day;
            meseDiNascita = data.Date.Month;
            annoDiNascita = data.Date.Year;
        }



        // ----------------------------------------------------------------------------------------------------



        // limitazioni textbox
        private void tbNomePaziente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void tbCognomePaziente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void tbIAggiungiIBAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
    }
}
