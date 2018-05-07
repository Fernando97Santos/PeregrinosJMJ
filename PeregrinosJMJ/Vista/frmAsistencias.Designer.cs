namespace PeregrinosJMJ.Vista
{
    partial class frmAsistencias
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbxPreAsistencia = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbxAsistencia = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cmbActividad = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbPeregrino = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Actividad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(166, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Asistencia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Pre-Asistencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(9, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Peregrino:";
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
            this.txtCodigo.Location = new System.Drawing.Point(9, 29);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(241, 41);
            this.txtCodigo.TabIndex = 64;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbxPreAsistencia
            // 
            this.cbxPreAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cbxPreAsistencia.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxPreAsistencia.Checked = true;
            this.cbxPreAsistencia.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cbxPreAsistencia.ForeColor = System.Drawing.Color.White;
            this.cbxPreAsistencia.Location = new System.Drawing.Point(92, 85);
            this.cbxPreAsistencia.Name = "cbxPreAsistencia";
            this.cbxPreAsistencia.Size = new System.Drawing.Size(20, 20);
            this.cbxPreAsistencia.TabIndex = 65;
            // 
            // cbxAsistencia
            // 
            this.cbxAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cbxAsistencia.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxAsistencia.Checked = true;
            this.cbxAsistencia.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cbxAsistencia.ForeColor = System.Drawing.Color.White;
            this.cbxAsistencia.Location = new System.Drawing.Point(230, 85);
            this.cbxAsistencia.Name = "cbxAsistencia";
            this.cbxAsistencia.Size = new System.Drawing.Size(20, 20);
            this.cbxAsistencia.TabIndex = 66;
            // 
            // cmbActividad
            // 
            this.cmbActividad.BackColor = System.Drawing.Color.Transparent;
            this.cmbActividad.BorderRadius = 3;
            this.cmbActividad.ForeColor = System.Drawing.Color.White;
            this.cmbActividad.Items = new string[0];
            this.cmbActividad.Location = new System.Drawing.Point(12, 131);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cmbActividad.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cmbActividad.selectedIndex = -1;
            this.cmbActividad.Size = new System.Drawing.Size(238, 35);
            this.cmbActividad.TabIndex = 67;
            // 
            // cmbPeregrino
            // 
            this.cmbPeregrino.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeregrino.BorderRadius = 3;
            this.cmbPeregrino.ForeColor = System.Drawing.Color.White;
            this.cmbPeregrino.Items = new string[0];
            this.cmbPeregrino.Location = new System.Drawing.Point(12, 196);
            this.cmbPeregrino.Name = "cmbPeregrino";
            this.cmbPeregrino.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cmbPeregrino.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.cmbPeregrino.selectedIndex = -1;
            this.cmbPeregrino.Size = new System.Drawing.Size(238, 35);
            this.cmbPeregrino.TabIndex = 68;
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
            this.btnLimpiar.Location = new System.Drawing.Point(695, 216);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnLimpiar.OnHovercolor = System.Drawing.Color.White;
            this.btnLimpiar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnLimpiar.selected = false;
            this.btnLimpiar.Size = new System.Drawing.Size(117, 48);
            this.btnLimpiar.TabIndex = 72;
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
            this.btnEliminar.Location = new System.Drawing.Point(553, 216);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(117, 48);
            this.btnEliminar.TabIndex = 71;
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
            this.btnModificar.Location = new System.Drawing.Point(415, 216);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnModificar.OnHovercolor = System.Drawing.Color.White;
            this.btnModificar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnModificar.selected = false;
            this.btnModificar.Size = new System.Drawing.Size(117, 48);
            this.btnModificar.TabIndex = 70;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Textcolor = System.Drawing.Color.White;
            this.btnModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = global::PeregrinosJMJ.Properties.Resources.guardar;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(271, 216);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(135)))), ((int)(((byte)(90)))));
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(120, 48);
            this.btnGuardar.TabIndex = 69;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(271, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(541, 193);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbPeregrino);
            this.panel1.Controls.Add(this.cbxPreAsistencia);
            this.panel1.Controls.Add(this.cmbActividad);
            this.panel1.Controls.Add(this.cbxAsistencia);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 252);
            this.panel1.TabIndex = 74;
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(824, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmAsistencias";
            this.Text = "frmAsistencias";
            this.VisibleChanged += new System.EventHandler(this.frmAsistencias_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        private Bunifu.Framework.UI.BunifuCheckbox cbxPreAsistencia;
        private Bunifu.Framework.UI.BunifuCheckbox cbxAsistencia;
        private Bunifu.Framework.UI.BunifuDropdown cmbActividad;
        private Bunifu.Framework.UI.BunifuDropdown cmbPeregrino;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpiar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}