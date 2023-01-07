using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioPsicologia
{
    public partial class RimuoviPaziente : Form
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

        public static RimuoviPaziente instance;
        public RimuoviPaziente()
        {
            InitializeComponent();
            instance = this;
        }



        // ----------------------------------------------------------------------------------------------------



        // form load
        private void RimuoviPaziente_Load_1(object sender, EventArgs e)
        {
            // bottoni
            btnRimuoviPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviPaziente.Width, btnRimuoviPaziente.Height, 10, 10));


            // cose bellissime, magnifiche
            MessageBox.Show("Mi è stato detto che non devo fare codesta cosa, ma completa la grafica, quindi rimarrà", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }



        // bottone rimuovi medico
        private void btnRimuoviPaziente_Click(object sender, EventArgs e)
        {
        }



        // ----------------------------------------------------------------------------------------------------



        // limitazioni textbox
        private void tbCodicePaziente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }  
    }
}
