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
            peregrinosList = aux.getPeregrinos();
            cargar();
        }
        Usuarios ADO = new Usuarios();
        Peregrino aux = new Peregrino();
        List<peregrinos> peregrinosList = new List<peregrinos>();

        private void LlenarData(List<PeregrinosJMJ.usuarios> nueva)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].HeaderText = "Codigo";
                dataGridView1.Columns[0].Name = "Codigo";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Usuario";
                dataGridView1.Columns[2].HeaderText = "contra";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Peregrino";
                dataGridView1.Columns[3].Width = dataGridView1.Columns[3].Width + 250;
                foreach (var item in nueva)
                {
                    dataGridView1.Rows.Add(item.id_usuario, item.username, item.contra, item.peregrinos.nombres);
                }
            }
            catch (Exception)
            {
                limpiar();
            }

        }
        private void cargar()
        {
            this.LlenarData(ADO.getUsuarios());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            //cmbPeregrino.DataSource = aux.getPeregrinos();
            //cmbPeregrino.DisplayMember = "nombres";
            //cmbPeregrino.ValueMember = "id_peregrino";
            cmbPeregrino.Clear();
            foreach (peregrinos pere in peregrinosList)
            {
                cmbPeregrino.AddItem(pere.nombres);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuarios nuevo = new usuarios();
            peregrinos p = aux.buscar(int.Parse(peregrinosList.Find(x => x.nombres.ToString().Contains(cmbPeregrino.selectedValue)).id_peregrino.ToString()));
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
            peregrinos p = aux.buscar(int.Parse(peregrinosList.Find(x => x.nombres.ToString().Contains(cmbPeregrino.selectedValue)).id_peregrino.ToString()));
            nuevo.id_usuario = int.Parse(txtCodigo.Text);
            nuevo.username = txtUsername.Text;
            nuevo.contra = txtContraseña.Text;
            nuevo.id_peregrino = p.id_peregrino;
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
        private void limpiar()
        {
            foreach (Control text in this.panel1.Controls)
            {
                if (!(text is Label))
                {
                    text.Text = "";
                }
            }
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        
    }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtContraseña.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtContraseña.isPassword = true;
                    int index = 0;
                    for (int i = 0; i >= -1; i++)
                    {
                        cmbPeregrino.selectedIndex = i;
                        //MessageBox.Show("Index: " + i + "   "+ cmbPeregrino.selectedValue+"=" + dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        if (cmbPeregrino.selectedValue.Equals(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
                        {
                            index = i;
                            break;
                        }
                    }
                    cmbPeregrino.selectedIndex = index;
                    cmbPeregrino.Refresh(); btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            catch (Exception)
            {
               // MessageBox.Show("Error al cargar: " + e);
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
                    txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtContraseña.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtContraseña.isPassword = true;
                    int index = 0;
                    for (int i = 0; i >= -1; i++)
                    {
                        cmbPeregrino.selectedIndex = i;
                        //MessageBox.Show("Index: " + i + "   "+ cmbPeregrino.selectedValue+"=" + dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        if (cmbPeregrino.selectedValue.Equals(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
                        {
                            index = i;
                            break;
                        }
                    }
                    cmbPeregrino.selectedIndex = index;
                    cmbPeregrino.Refresh(); btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            catch (Exception)
            {
               // MessageBox.Show("Error al cargar: " + e);
                limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmUsuarios_VisibleChanged(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
