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
        }

        Peregrino ADO = new Peregrino();

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEdad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtSexo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtCasa.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtMovil.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtMinisterio.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtJMJ.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
