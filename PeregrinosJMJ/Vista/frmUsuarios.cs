using PeregrinosJMJ.Clases;
using PeregrinosJMJ.Modelo;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            cargar();
        }
        Usuarios ADO = new Usuarios();
        Peregrino aux = new Peregrino();

        private void LlenarData(List<PeregrinosJMJ.usuarios> nueva)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in nueva)
            {
                dataGridView1.Rows.Add(item.id_usuario, item.username, item.contra, item.peregrinos.nombres);
            }

        }
        private void cargar()
        {
            this.LlenarData(ADO.getUsuarios());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            cmbPeregrino.DataSource = aux.getPeregrinos();
            cmbPeregrino.DisplayMember = "nombres";
            cmbPeregrino.ValueMember = "id_peregrino";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuarios nuevo = new usuarios();
            peregrinos p = aux.buscar(int.Parse(cmbPeregrino.SelectedValue.ToString()));
            nuevo.username = txtUsername.Text;
            nuevo.contra = txtContraseña.Text;
            nuevo.id_peregrino = p.id_peregrino;
            p.usuarios.Add(nuevo);

            if (ADO.agregar(nuevo) == 1)
            {
                MessageBox.Show("Usuario agregado con exito :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            usuarios nuevo = ADO.buscar(int.Parse(txtCodigo.Text));
            peregrinos p = aux.buscar(int.Parse(cmbPeregrino.SelectedValue.ToString()));
            nuevo.id_usuario = int.Parse(txtCodigo.Text);
            nuevo.username = txtUsername.Text;
            nuevo.contra = txtContraseña.Text;
            nuevo.id_peregrino = int.Parse(cmbPeregrino.SelectedValue.ToString());
            p.usuarios.Add(nuevo);

            if (ADO.modificar(nuevo) == 1)
            {
                MessageBox.Show("Usuario modificado con exito :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ADO.eliminar(int.Parse(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Usuario eliminado con exito :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbPeregrino.SelectedIndex = cmbPeregrino.FindString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
    }
}
