namespace PeregrinosJMJ.Vista
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInve = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAsistencia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPere = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinim = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnActi);
            this.pnlMenu.Controls.Add(this.btnInve);
            this.pnlMenu.Controls.Add(this.btnAsistencia);
            this.pnlMenu.Controls.Add(this.btnPere);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 36);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 342);
            this.pnlMenu.TabIndex = 6;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.pnlHeader.Controls.Add(this.btnMinim);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(-1, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(994, 37);
            this.pnlHeader.TabIndex = 7;
            this.pnlHeader.MouseHover += new System.EventHandler(this.pnlHeader_MouseHover);
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(172, 36);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(806, 331);
            this.pnlBody.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = global::PeregrinosJMJ.Properties.Resources.salir;
            this.btnSalir.Iconimage_right = null;
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 90D;
            this.btnSalir.IsTab = false;
            this.btnSalir.Location = new System.Drawing.Point(0, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.White;
            this.btnSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(201)))), ((int)(((byte)(139)))));
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(175, 48);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnSalir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActi
            // 
            this.btnActi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.btnActi.BackColor = System.Drawing.Color.White;
            this.btnActi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActi.BorderRadius = 0;
            this.btnActi.ButtonText = "Actividades";
            this.btnActi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActi.DisabledColor = System.Drawing.Color.Gray;
            this.btnActi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActi.Iconimage = global::PeregrinosJMJ.Properties.Resources.activity;
            this.btnActi.Iconimage_right = null;
            this.btnActi.Iconimage_right_Selected = null;
            this.btnActi.Iconimage_Selected = null;
            this.btnActi.IconMarginLeft = 0;
            this.btnActi.IconMarginRight = 0;
            this.btnActi.IconRightVisible = true;
            this.btnActi.IconRightZoom = 0D;
            this.btnActi.IconVisible = true;
            this.btnActi.IconZoom = 90D;
            this.btnActi.IsTab = false;
            this.btnActi.Location = new System.Drawing.Point(0, 181);
            this.btnActi.Name = "btnActi";
            this.btnActi.Normalcolor = System.Drawing.Color.White;
            this.btnActi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(201)))), ((int)(((byte)(139)))));
            this.btnActi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnActi.selected = false;
            this.btnActi.Size = new System.Drawing.Size(175, 48);
            this.btnActi.TabIndex = 11;
            this.btnActi.Text = "Actividades";
            this.btnActi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActi.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnActi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActi.Click += new System.EventHandler(this.btnActi_Click);
            // 
            // btnInve
            // 
            this.btnInve.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.btnInve.BackColor = System.Drawing.Color.White;
            this.btnInve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInve.BorderRadius = 0;
            this.btnInve.ButtonText = "Inversion";
            this.btnInve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInve.DisabledColor = System.Drawing.Color.Gray;
            this.btnInve.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInve.Iconimage = global::PeregrinosJMJ.Properties.Resources.money;
            this.btnInve.Iconimage_right = null;
            this.btnInve.Iconimage_right_Selected = null;
            this.btnInve.Iconimage_Selected = null;
            this.btnInve.IconMarginLeft = 0;
            this.btnInve.IconMarginRight = 0;
            this.btnInve.IconRightVisible = true;
            this.btnInve.IconRightZoom = 0D;
            this.btnInve.IconVisible = true;
            this.btnInve.IconZoom = 90D;
            this.btnInve.IsTab = false;
            this.btnInve.Location = new System.Drawing.Point(0, 136);
            this.btnInve.Name = "btnInve";
            this.btnInve.Normalcolor = System.Drawing.Color.White;
            this.btnInve.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(201)))), ((int)(((byte)(139)))));
            this.btnInve.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnInve.selected = false;
            this.btnInve.Size = new System.Drawing.Size(175, 48);
            this.btnInve.TabIndex = 10;
            this.btnInve.Text = "Inversion";
            this.btnInve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInve.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnInve.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInve.Click += new System.EventHandler(this.btnInve_Click_1);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.btnAsistencia.BackColor = System.Drawing.Color.White;
            this.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsistencia.BorderRadius = 0;
            this.btnAsistencia.ButtonText = "Asistencia";
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.DisabledColor = System.Drawing.Color.Gray;
            this.btnAsistencia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAsistencia.Iconimage = global::PeregrinosJMJ.Properties.Resources.check;
            this.btnAsistencia.Iconimage_right = null;
            this.btnAsistencia.Iconimage_right_Selected = null;
            this.btnAsistencia.Iconimage_Selected = null;
            this.btnAsistencia.IconMarginLeft = 0;
            this.btnAsistencia.IconMarginRight = 0;
            this.btnAsistencia.IconRightVisible = true;
            this.btnAsistencia.IconRightZoom = 0D;
            this.btnAsistencia.IconVisible = true;
            this.btnAsistencia.IconZoom = 90D;
            this.btnAsistencia.IsTab = false;
            this.btnAsistencia.Location = new System.Drawing.Point(0, 91);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Normalcolor = System.Drawing.Color.White;
            this.btnAsistencia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(201)))), ((int)(((byte)(139)))));
            this.btnAsistencia.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnAsistencia.selected = false;
            this.btnAsistencia.Size = new System.Drawing.Size(175, 48);
            this.btnAsistencia.TabIndex = 7;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnAsistencia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnPere
            // 
            this.btnPere.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.btnPere.BackColor = System.Drawing.Color.White;
            this.btnPere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPere.BorderRadius = 0;
            this.btnPere.ButtonText = "Peregrinos";
            this.btnPere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPere.DisabledColor = System.Drawing.Color.Gray;
            this.btnPere.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPere.Iconimage = global::PeregrinosJMJ.Properties.Resources.cross;
            this.btnPere.Iconimage_right = null;
            this.btnPere.Iconimage_right_Selected = null;
            this.btnPere.Iconimage_Selected = null;
            this.btnPere.IconMarginLeft = 0;
            this.btnPere.IconMarginRight = 0;
            this.btnPere.IconRightVisible = true;
            this.btnPere.IconRightZoom = 0D;
            this.btnPere.IconVisible = true;
            this.btnPere.IconZoom = 90D;
            this.btnPere.IsTab = false;
            this.btnPere.Location = new System.Drawing.Point(0, 46);
            this.btnPere.Name = "btnPere";
            this.btnPere.Normalcolor = System.Drawing.Color.White;
            this.btnPere.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(201)))), ((int)(((byte)(139)))));
            this.btnPere.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnPere.selected = false;
            this.btnPere.Size = new System.Drawing.Size(175, 48);
            this.btnPere.TabIndex = 6;
            this.btnPere.Text = "Peregrinos";
            this.btnPere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPere.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnPere.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPere.Click += new System.EventHandler(this.btnPere_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.btnUsuarios.BackColor = System.Drawing.Color.White;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.BorderRadius = 0;
            this.btnUsuarios.ButtonText = "Usuarios";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Iconimage = global::PeregrinosJMJ.Properties.Resources.user;
            this.btnUsuarios.Iconimage_right = null;
            this.btnUsuarios.Iconimage_right_Selected = null;
            this.btnUsuarios.Iconimage_Selected = null;
            this.btnUsuarios.IconMarginLeft = 0;
            this.btnUsuarios.IconMarginRight = 0;
            this.btnUsuarios.IconRightVisible = true;
            this.btnUsuarios.IconRightZoom = 0D;
            this.btnUsuarios.IconVisible = true;
            this.btnUsuarios.IconZoom = 90D;
            this.btnUsuarios.IsTab = false;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.Color.White;
            this.btnUsuarios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(201)))), ((int)(((byte)(139)))));
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnUsuarios.selected = false;
            this.btnUsuarios.Size = new System.Drawing.Size(175, 48);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnUsuarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click_1);
            // 
            // btnMinim
            // 
            this.btnMinim.BackColor = System.Drawing.Color.Transparent;
            this.btnMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinim.Image = global::PeregrinosJMJ.Properties.Resources._268_minus;
            this.btnMinim.ImageActive = null;
            this.btnMinim.Location = new System.Drawing.Point(956, 0);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Padding = new System.Windows.Forms.Padding(5);
            this.btnMinim.Size = new System.Drawing.Size(35, 37);
            this.btnMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinim.TabIndex = 2;
            this.btnMinim.TabStop = false;
            this.btnMinim.Zoom = 10;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 379);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "ViajerosJMJ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuFlatButton btnPere;
        private Bunifu.Framework.UI.BunifuFlatButton btnAsistencia;
        private Bunifu.Framework.UI.BunifuFlatButton btnInve;
        private Bunifu.Framework.UI.BunifuFlatButton btnActi;
        private Bunifu.Framework.UI.BunifuImageButton btnMinim;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
    }
}