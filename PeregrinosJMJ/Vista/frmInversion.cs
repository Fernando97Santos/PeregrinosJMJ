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
            actividadesList = aux.getActividades();
            cargar();
        }

        Inversion ADO = new Inversion();
        Actividades aux = new Actividades();
        List<actividades> actividadesList = new List<actividades>();
        private void cargar()
        {
            this.LlenarData(ADO.getInversion());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            //cmbActividad.DataSource = aux.getActividades();
            //cmbActividad.DisplayMember = "actividad";
            //cmbActividad.ValueMember = "id_actividad";
            cmbActividad.Clear();
            foreach (actividades act in actividadesList)
            {
                cmbActividad.AddItem(act.actividad);
            }

        }

        private void LlenarData(List<inversion> nueva)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].HeaderText = "Codigo";
                dataGridView1.Columns[0].Name = "Codigo";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Producto";
                dataGridView1.Columns[1].Name = "Producto";
                dataGridView1.Columns[2].Name = "Monto";
                dataGridView1.Columns[2].HeaderText = "Monto";
                dataGridView1.Columns[3].Name = "Actividad";
                dataGridView1.Columns[3].HeaderText = "Actividad";
                dataGridView1.Columns[1].Width = dataGridView1.Columns[1].Width + 30;
                dataGridView1.Columns[2].Width = dataGridView1.Columns[2].Width + 20;
                dataGridView1.Columns[3].Width = dataGridView1.Columns[3].Width + 30;
                foreach (var item in nueva)
                {
                    dataGridView1.Rows.Add(item.id_inversion, item.producto, item.monto, item.actividades.actividad);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar tabla: " + e);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            inversion nuevo = new inversion();
            //actividades p = aux.buscar(int.Parse(cmbActividad.SelectedValue.ToString()));
            actividades p = aux.buscar(int.Parse(actividadesList.Find(x => x.actividad.ToString().Contains(cmbActividad.selectedValue)).id_actividad.ToString()));
            nuevo.producto = txtProducto.Text;
            nuevo.monto = float.Parse(txtMonto.Text);
            nuevo.id_actividad = p.id_actividad;
            //p.inversion.Add(nuevo);

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
            //actividades p = aux.buscar(int.Parse(cmbActividad.SelectedValue.ToString()));
            actividades a = aux.buscar(int.Parse(actividadesList.Find(x => x.actividad.ToString().Contains(cmbActividad.selectedValue)).id_actividad.ToString()));
            nuevo.id_inversion = int.Parse(txtCodigo.Text);
            nuevo.producto = txtProducto.Text;
            nuevo.monto = float.Parse(txtMonto.Text);
            nuevo.id_actividad = a.id_actividad;
            //p.inversion.Add(nuevo);

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

        private void frmInversion_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtMonto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    //cmbActividad.SelectedIndex = cmbActividad.FindString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    //cmbActividad.SelectedIndex = cmbActividad.FindString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    int index = 0;
                    for (int i = 0; i >= -1; i++)
                    {
                        cmbActividad.selectedIndex = i;
                        //MessageBox.Show("Index: " + i + "   " + cmbActividad.selectedValue + "=" + dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        if (cmbActividad.selectedValue.Equals(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
                        {
                            index = i;
                            break;
                        }
                    }
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            catch(Exception)
            {
                // MessageBox.Show("Error Cargar datos: " + e);
                limpiar();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtMonto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    //cmbActividad.SelectedIndex = cmbActividad.FindString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    //cmbActividad.SelectedIndex = cmbActividad.FindString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    int index = 0;
                    for (int i = 0; i >= -1; i++)
                    {
                        cmbActividad.selectedIndex = i;
                       // MessageBox.Show("Index: " + i + "   " + cmbActividad.selectedValue + "=" + dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        if (cmbActividad.selectedValue.Equals(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
                        {
                            index = i;
                            break;
                        }
                    }
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            catch (Exception)
            {
                // MessageBox.Show("Error Cargar datos: " + e);
                limpiar();
            }
        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtMonto.Text = "";
            txtProducto.Text = "";
            cmbActividad.selectedIndex = 0;
            cmbActividad.ResetText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
