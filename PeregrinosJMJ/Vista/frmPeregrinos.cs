using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeregrinosJMJ.Clases;

namespace PeregrinosJMJ
{
    public partial class frmPeregrino : Form
    {
        public frmPeregrino()
        {
            InitializeComponent();
            cargar();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }

        Peregrino ADO = new Peregrino();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            peregrinos nuevo = new peregrinos();
            nuevo.nombres = txtNombre.Text;
            nuevo.apellidos = txtApellido.Text;
            nuevo.edad = int.Parse(txtEdad.Text);
            nuevo.sexo = txtSexo.Text;
            nuevo.correo = txtCorreo.Text;
            nuevo.tele_casa = txtCasa.Text;
            nuevo.tele_celu = txtMovil.Text;
            nuevo.ministerio = txtMinisterio.Text;
            nuevo.jmj = txtJMJ.Text;

            if (ADO.agregarPeregrino(nuevo) == 1)
            {
                MessageBox.Show("Peregrino agregado con extio :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }
        private void cargar()
        {
            dataGridView1.DataSource = ADO.getPeregrinos();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Name = "Codigo";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Apellido";
            dataGridView1.Columns[3].HeaderText = "Edad";
            dataGridView1.Columns[4].HeaderText = "Sexo";
            dataGridView1.Columns[5].HeaderText = "Correo";
            dataGridView1.Columns[6].HeaderText = "Telefono Casa";
            dataGridView1.Columns[7].HeaderText = "Telefono Movil";
            dataGridView1.Columns[8].HeaderText = "Ministerio";
            dataGridView1.Columns[9].HeaderText = "JMJ";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ADO.eliminar(int.Parse(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Peregrino eliminado con extio :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            peregrinos nuevo = ADO.buscar(int.Parse(txtCodigo.Text));
            nuevo.id_peregrino = int.Parse(txtCodigo.Text);
            nuevo.nombres = txtNombre.Text;
            nuevo.apellidos = txtApellido.Text;
            nuevo.edad = int.Parse(txtEdad.Text);
            nuevo.sexo = txtSexo.Text;
            nuevo.correo = txtCorreo.Text;
            nuevo.tele_casa = txtCasa.Text;
            nuevo.tele_celu = txtMovil.Text;
            nuevo.ministerio = txtMinisterio.Text;
            nuevo.jmj = txtJMJ.Text;
            
            if (ADO.modificar(nuevo) == 1)
            {
                MessageBox.Show("Peregrino modificado con extio :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }
        private void limpiar()
        {
            foreach(Control text in this.panel1.Controls)
            {
                if(!(text is Label))
                {
                    text.Text = "";
                }
            }
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    int index = this.panel1.Controls.Count/2 -1;
                    foreach (Control text in this.panel1.Controls)
                    {
                       
                        if (!(text is Label))
                        {
                           
                            text.Text = dataGridView1.CurrentRow.Cells[index].Value.ToString();
                            index--;
                        }
                    }
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            catch (Exception )
            {
                // MessageBox.Show("Error al consultar: "+ e);
                limpiar();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    int index = this.panel1.Controls.Count/2 -1;
                    foreach (Control text in this.panel1.Controls)
                    {
                        if(!(text is Label))
                        {
                            text.Text = dataGridView1.CurrentRow.Cells[index].Value.ToString();
                            index--;
                        }
                    }
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            catch (Exception)
            {
                // MessageBox.Show("Error al consultar: " + e);
                limpiar();
            }
        }

        private void frmPeregrino_VisibleChanged(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
