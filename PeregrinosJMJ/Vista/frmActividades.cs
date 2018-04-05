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
    public partial class frmActividades : Form
    {
        public frmActividades()
        {
            InitializeComponent();
            cargar();
        }
        Actividades ADO = new Actividades();
        private void cargar()
        {
            dataGridView1.DataSource = ADO.getActividades();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            actividades nuevo = new actividades();
            nuevo.actividad = txtActividad.Text;
            nuevo.fecha = txtFecha.Value.Date;
            nuevo.lugar = txtLugar.Text;
            nuevo.ganacia = float.Parse(txtGanancia.Text);

            if (ADO.agregar(nuevo) == 1)
            {
                MessageBox.Show("Actividad agregada con exito :D");
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
                MessageBox.Show("Actividad eliminada con exito :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actividades nuevo = ADO.buscar(int.Parse(txtCodigo.Text));
            nuevo.id_actividad = int.Parse(txtCodigo.Text);
            nuevo.actividad = txtActividad.Text;
            nuevo.fecha = txtFecha.Value.Date;
            nuevo.lugar = txtLugar.Text;
            nuevo.ganacia = float.Parse(txtGanancia.Text);

            if (ADO.modificar(nuevo) == 1)
            {
                MessageBox.Show("Actividad modificada con exito :D");
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
                txtActividad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtFecha.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtLugar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtGanancia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
    }
}
