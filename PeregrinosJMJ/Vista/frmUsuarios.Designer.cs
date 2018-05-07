namespace PeregrinosJMJ.Vista
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbPeregrino = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Peregrino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Usuario:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigo.HintText = "";
            this.txtCodigo.isPassword = false;
            this.txtCodigo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.txtCodigo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.txtCodigo.LineThickness = 3;
            this.txtCodigo.Location = new System.Drawing.Point(21, 36);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(241, 41);
            this.txtCodigo.TabIndex = 65;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(21, 118);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 41);
            this.txtUsername.TabIndex = 66;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.HintForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.HintText = "";
            this.txtContraseña.isPassword = true;
            this.txtContraseña.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.txtContraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.txtContraseña.LineThickness = 3;
            this.txtContraseña.Location = new System.Drawing.Point(25, 189);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(241, 41);
            this.txtContraseña.TabIndex = 67;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbPeregrino
            // 
            this.cmbPeregrino.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeregrino.BorderRadius = 3;
            this.cmbPeregrino.ForeColor = System.Drawing.Color.White;
            this.cmbPeregrino.Items = new string[0];
            this.cmbPeregrino.Location = new System.Drawing.Point(21, 259);
            this.cmbPeregrino.Name = "cmbPeregrino";
            this.cmbPeregrino.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cmbPeregrino.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cmbPeregrino.selectedIndex = -1;
            this.cmbPeregrino.Size = new System.Drawing.Size(238, 35);
            this.cmbPeregrino.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbPeregrino);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 319);
            this.panel1.TabIndex = 70;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.BorderRadius = 0;
            this.btnLimpiar.ButtonText = "Limpiar";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.btnLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Iconimage = global::PeregrinosJMJ.Properties.Resources.limpiar;
            this.btnLimpiar.Iconimage_right = null;
            this.btnLimpiar.Iconimage_right_Selected = null;
            this.btnLimpiar.Iconimage_Selected = null;
            this.btnLimpiar.IconMarginLeft = 0;
            this.btnLimpiar.IconMarginRight = 0;
            this.btnLimpiar.IconRightVisible = true;
            this.btnLimpiar.IconRightZoom = 0D;
            this.btnLimpiar.IconVisible = true;
            this.btnLimpiar.IconZoom = 90D;
            this.btnLimpiar.IsTab = false;
            this.btnLimpiar.Location = new System.Drawing.Point(730, 272);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnLimpiar.OnHovercolor = System.Drawing.Color.White;
            this.btnLimpiar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnLimpiar.selected = false;
            this.btnLimpiar.Size = new System.Drawing.Size(117, 48);
            this.btnLimpiar.TabIndex = 76;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Textcolor = System.Drawing.Color.White;
            this.btnLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = global::PeregrinosJMJ.Properties.Resources.eliminar;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(588, 272);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(117, 48);
            this.btnEliminar.TabIndex = 75;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.ButtonText = "Modificar";
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificar.Iconimage = global::PeregrinosJMJ.Properties.Resources.modificar;
            this.btnModificar.Iconimage_right = null;
            this.btnModificar.Iconimage_right_Selected = null;
            this.btnModificar.Iconimage_Selected = null;
            this.btnModificar.IconMarginLeft = 0;
            this.btnModificar.IconMarginRight = 0;
            this.btnModificar.IconRightVisible = true;
            this.btnModificar.IconRightZoom = 0D;
            this.btnModificar.IconVisible = true;
            this.btnModificar.IconZoom = 90D;
            this.btnModificar.IsTab = false;
            this.btnModificar.Location = new System.Drawing.Point(450, 272);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnModificar.OnHovercolor = System.Drawing.Color.White;
            this.btnModificar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnModificar.selected = false;
            this.btnModificar.Size = new System.Drawing.Size(117, 48);
            this.btnModificar.TabIndex = 74;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Textcolor = System.Drawing.Color.White;
            this.btnModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "Guardar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = global::PeregrinosJMJ.Properties.Resources.guardar;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(306, 272);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnAgregar.OnHovercolor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(120, 48);
            this.btnAgregar.TabIndex = 73;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(306, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(541, 245);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(855, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.VisibleChanged += new System.EventHandler(this.frmUsuarios_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuDropdown cmbPeregrino;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpiar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
    }
}