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
            limpiar();
        }

        Actividades ADO = new Actividades();
        private void cargar()
        {
            dataGridView1.DataSource = ADO.getActividades();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Name = "Codigo";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Actividad";
            dataGridView1.Columns[1].Name = "Actividad";
            dataGridView1.Columns[2].Name = "Fecha";
            dataGridView1.Columns[2].HeaderText = "Fecha";
            dataGridView1.Columns[3].Name = "Lugar";
            dataGridView1.Columns[3].HeaderText = "Lugar";
            dataGridView1.Columns[4].Name = "Ganancia";
            dataGridView1.Columns[4].HeaderText = "Ganancia";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].Width = dataGridView1.Columns[1].Width + 30;
            dataGridView1.Columns[2].Width = dataGridView1.Columns[2].Width + 20;
            dataGridView1.Columns[3].Width = dataGridView1.Columns[3].Width + 30;
            dataGridView1.Columns[4].Width = dataGridView1.Columns[4].Width + 20;
            dataGridView1.Refresh();
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



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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

        private void btnModi_Click(object sender, EventArgs e)
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

        private void btnElim_Click(object sender, EventArgs e)
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                limpiar();
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                limpiar();
            }
        }
        private void limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtActividad.Text = "";
            this.txtGanancia.Text = "";
            this.txtLugar.Text = "";
            this.txtFecha.ResetText();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmActividades_VisibleChanged(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
