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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            alturaForm = this.Height;
            alturaMenu = this.pnlMenu.Height;
        }
        int alturaForm = 0;
        int alturaMenu = 0;
        private void mostrar(Form content)
        {
            Color blanco = Color.FromArgb(255, 255, 255);
            this.btnActi.Normalcolor = blanco;
            this.btnAsistencia.Normalcolor = blanco;
            this.btnInve.Normalcolor = blanco;
            this.btnPere.Normalcolor = blanco;
            this.btnUsuarios.Normalcolor = blanco;
            if (this.pnlBody.Controls.Count > 0)
                this.pnlBody.Controls.RemoveAt(0);
            content.TopLevel = false;
            content.FormBorderStyle = FormBorderStyle.None;
            content.Dock = DockStyle.Fill;
            pnlBody.Padding = new Padding(10);
            this.pnlBody.Controls.Add(content);
            this.pnlBody.Tag = content;
                       
           this.pnlBody.Height = content.Height + 10;
            if(content.Height < alturaForm)
            {
                //this.Height = 167 + 37;
                this.Height = alturaForm +20;
                this.pnlMenu.Height = alturaMenu+20;
            }
            else
            {
                this.Height = content.Height + 37 +20;
                this.pnlMenu.Height = content.Height + 20;
            }
            pnlBody.Width = content.Width +25;
            this.Width = pnlMenu.Width + content.Width+25;
            btnMinim.Left = this.Width - 37;
            pnlHeader.Width = this.Width;
            content.Show();
        }


        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            mostrar(new frmUsuarios());
            this.btnUsuarios.Normalcolor = this.btnUsuarios.OnHovercolor;
        }

        private void btnPere_Click(object sender, EventArgs e)
        {
            mostrar(new frmPeregrino());
            this.btnPere.Normalcolor = this.btnPere.OnHovercolor;
        }
        
        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            mostrar(new frmAsistencias(this));
            this.btnAsistencia.Normalcolor = this.btnAsistencia.OnHovercolor ;
        }
        public void mostrarAsistencia() {
            mostrar(new frmAsistencias(this));
            this.btnAsistencia.Normalcolor = this.btnAsistencia.OnHovercolor;
        }

        private void btnInve_Click_1(object sender, EventArgs e)
        {
            mostrar(new frmInversion());
            this.btnInve.Normalcolor = this.btnInve.OnHovercolor;
        }

        private void btnActi_Click(object sender, EventArgs e)
        {
            mostrar(new frmActividades());
            this.btnActi.Normalcolor = this.btnActi.OnHovercolor;
        }

        //                  PROGRAMANDO QUE SE PUEDA MOVER FORM SIN BORDES
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_Load);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);

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

        private void pnlHeader_MouseHover(object sender, EventArgs e)
        {
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_Load);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            new FrmSalir(this).Show();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Enabled = false;
        }
    }
}
