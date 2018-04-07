using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeregrinosJMJ.Vista
{
    public partial class FrmSalir : Form
    {
        public FrmSalir()
        {
            InitializeComponent();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_Load);
            this.pnlBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
        }
        public FrmSalir(Form Padre)
        {
            InitializeComponent();
            padre = Padre;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_Load);
            this.pnlBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
        }
        Form padre = null;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            padre.Enabled = true;
            padre.WindowState = FormWindowState.Normal;
            this.Hide();
        }
        //                  PROGRAMANDO QUE SE PUEDA MOVER FORM SIN BORDES
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_Load);
            this.pnlBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);

        }
        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        // 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // 
        // función privada usada para mover el formulario actual 

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_Load);
            this.pnlBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
        }
    }
}
