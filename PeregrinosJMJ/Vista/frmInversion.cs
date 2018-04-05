using PeregrinosJMJ.Controladores;
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
    public partial class frmInversion : Form
    {
        public frmInversion()
        {
            InitializeComponent();
            cargar();
        }

        Inversion ADO = new Inversion();
        Actividades aux = new Actividades();

        private void cargar()
        {
            this.LlenarData(ADO.getInversion());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            cmbActividad.DataSource = aux.getActividades();
            cmbActividad.DisplayMember = "actividad";
            cmbActividad.ValueMember = "id_actividad";
        }

        private void LlenarData(List<inversion> nueva)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in nueva)
            {
                dataGridView1.Rows.Add(item.id_inversion, item.producto, item.monto, item.actividades.actividad);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            inversion nuevo = new inversion();
            actividades p = aux.buscar(int.Parse(cmbActividad.SelectedValue.ToString()));
            nuevo.producto = txtProducto.Text;
            nuevo.monto = float.Parse(txtMonto.Text);
            nuevo.id_actividad = p.id_actividad;
            p.inversion.Add(nuevo);

            if (ADO.guardar(nuevo) == 1)
            {
                MessageBox.Show("Inversion agregada con exito :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            inversion nuevo = ADO.buscar(int.Parse(txtCodigo.Text));
            actividades p = aux.buscar(int.Parse(cmbActividad.SelectedValue.ToString()));
            nuevo.id_inversion = int.Parse(txtCodigo.Text);
            nuevo.producto = txtProducto.Text;
            nuevo.monto = float.Parse(txtMonto.Text);
            nuevo.id_actividad = int.Parse(cmbActividad.SelectedValue.ToString());
            p.inversion.Add(nuevo);

            if (ADO.modificar(nuevo) == 1)
            {
                MessageBox.Show("Inversion modificada con exito :D");
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
                MessageBox.Show("Inversion eliminada con exito :D");
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
                txtProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtMonto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbActividad.SelectedIndex = cmbActividad.FindString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        private void frmInversion_Load(object sender, EventArgs e)
        {

        }
    }
}
