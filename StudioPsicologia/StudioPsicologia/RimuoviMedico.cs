using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioPsicologia
{
    public partial class RimuoviMedico : Form
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

        public static RimuoviMedico instance;
        public RimuoviMedico()
        {
            instance = this;
            InitializeComponent();
        }



        // ----------------------------------------------------------------------------------------------------



        // form load
        private void RimuoviMedico_Load(object sender, EventArgs e)
        {
            // bottoni
            btnRimuoviMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviMedico.Width, btnRimuoviMedico.Height, 10, 10));

            //caricaMedici
            caricaMedici();
            caricaCbMedici();
        }

        List<Medico> medici = new List<Medico>();


        // bottone rimuovi medico
        private void btnRimuoviMedico_Click(object sender, EventArgs e)
        {
            if (cbMedici.Text != "")
            {
                string codiceMedico = cbMedici.Text.Split(' ')[2];
                if (rimuoviMedicoDallaCarica(codiceMedico))
                {
                    // ricarica medici
                    Form1.instance.caricaMedici();
                    Form1.instance.caricaCbMedici();
                    Form1.instance.caricaCbListaMedici();

                    MessageBox.Show("Il medico è stato rimosso dalla carica", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Il codice inserito non esiste", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // funzione riscrivi medico
        public bool rimuoviMedicoDallaCarica(string codiceMedico)
        {
            Medico med = new Medico();
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                fs.Seek(med.getByte() - med.lunghezzaCodice(), SeekOrigin.Current);
                string codiceLetto = leggi.ReadString();

                if (codiceLetto == codiceMedico)
                {
                    fs.Seek(- (med.lunghezzaCodice() + 4 + 4 + 1), SeekOrigin.Current);

                    // rimuovi dalla carica
                    bool inCarica = false;
                    scrivi.Write(inCarica);

                    fs.Close();
                    return true;
                }
            }
            fs.Close();
            return false;
        }


        // funzione carica medici da file
        private void caricaMedici()
        {
            medici.Clear();

            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Medico med = new Medico();

                med._nome = leggi.ReadString().Trim(' ');
                med._cognome = leggi.ReadString().Trim(' ');
                med._specializzazione = leggi.ReadString().Trim(' ');
                med._inCarica = leggi.ReadBoolean();
                med._inizioOrario = leggi.ReadInt32();
                med._fineOrario = leggi.ReadInt32();

                fs.Seek(11, SeekOrigin.Current);

                if (med._inCarica)
                    medici.Add(med);
            }
            fs.Close();
        }


        // funzione carica medici nella combobox
        public void caricaCbMedici()
        {
            cbMedici.Items.Clear();
            for (int i = 0; i < medici.Count; i++)
                cbMedici.Items.Add($"{medici[i]._nome} {medici[i]._cognome} {medici[i].getCodice()}");
        }



        // ----------------------------------------------------------------------------------------------------



        // limitazioni textbox
        private void tbCodiceMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
    }
}
