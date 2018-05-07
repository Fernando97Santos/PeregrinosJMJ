using PeregrinosJMJ.Clases;
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
    public partial class frmAsistencias : Form
    {
        public frmAsistencias()
        {
            InitializeComponent();
            actividadesList = auxActi.getActividades();
            peregrinosList = auxPere.getPeregrinos();
            cargar();
        }
        public frmAsistencias(frmPrincipal father)
        {
            InitializeComponent();
            this.padre = father;
            actividadesList = auxActi.getActividades();
            peregrinosList = auxPere.getPeregrinos();
            cargar();
        }

        Asistencia ADO = new Asistencia();
        Actividades auxActi = new Actividades();
        Peregrino auxPere = new Peregrino();
        List<actividades> actividadesList = new List<actividades>();
        List<peregrinos> peregrinosList = new List<peregrinos>();
        frmPrincipal padre = new frmPrincipal();
        private void cargar()
        {
            this.LlenarData(ADO.getAsistencias());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            //cmbActividad.DataSource = auxActi.getActividades();
            //cmbActividad.DisplayMember = "actividad";
            //cmbActividad.ValueMember = "id_actividad";
            //cmbPeregrino.DataSource = auxPere.getPeregrinos();
            //cmbPeregrino.DisplayMember = "nombres";
            //cmbPeregrino.ValueMember = "id_peregrino";
            cmbActividad.Clear();
            cmbPeregrino.Clear();
            foreach (actividades act in actividadesList)
            {
                cmbActividad.AddItem(act.actividad);
            }
            foreach (peregrinos pere in peregrinosList)
            {
                cmbPeregrino.AddItem(pere.nombres);
            }

        }

        private void LlenarData(List<asistencia> nueva)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].HeaderText = "Codigo";
                dataGridView1.Columns[0].Name = "Codigo";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Pre-Asistencia";
                dataGridView1.Columns[1].Name = "Pre-Asistencia";
                dataGridView1.Columns[2].Name = "Asistencia";
                dataGridView1.Columns[2].HeaderText = "Asistencia";
                dataGridView1.Columns[3].Name = "Actividad";
                dataGridView1.Columns[3].HeaderText = "Actividad";
                dataGridView1.Columns[4].Name = "Peregrino";
                dataGridView1.Columns[4].HeaderText = "Peregrino";
                dataGridView1.Columns[1].Width = dataGridView1.Columns[1].Width + 30;
                dataGridView1.Columns[2].Width = dataGridView1.Columns[2].Width + 20;
                dataGridView1.Columns[3].Width = dataGridView1.Columns[3].Width + 30;
                dataGridView1.Columns[4].Width = dataGridView1.Columns[4].Width + 20;
                foreach (asistencia item in nueva)
                {
                    dataGridView1.Rows.Add(item.id_asistencia, item.pre_asis == 1 ? "SI" : "NO", item.asis == 1 ? "SI" : "NO", item.actividades.actividad, item.peregrinos.nombres);
                }
                dataGridView1.Refresh();
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error cargando tabla: " + e);
                limpiar();
            }
        }
     

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                asistencia nuevo = new asistencia();
                actividades a = auxActi.buscar(int.Parse(actividadesList.Find(x => x.actividad.ToString().Contains(cmbActividad.selectedValue)).id_actividad.ToString()));
                peregrinos p = auxPere.buscar(int.Parse(peregrinosList.Find(x => x.nombres.ToString().Contains(cmbPeregrino.selectedValue)).id_peregrino.ToString()));
                nuevo.pre_asis = cbxPreAsistencia.Checked ? 1 : 0;
                nuevo.asis = cbxAsistencia.Checked ? 1 : 0;
                nuevo.id_actividad = a.id_actividad;
                nuevo.id_peregrino = p.id_peregrino;
                p.asistencia.Add(nuevo);
                a.asistencia.Add(nuevo);

                if (ADO.guardar(nuevo) == 1)
                {
                    MessageBox.Show("Asistencia agregada con exito :D");
                    padre.mostrarAsistencia();
                    //cargar();
                    //limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar: ");
                padre.mostrarAsistencia();
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                asistencia nuevo = ADO.buscar(int.Parse(txtCodigo.Text));
                //actividades a = auxActi.buscar(int.Parse(cmbActividad.SelectedValue.ToString()));
                // peregrinos p = auxPere.buscar(int.Parse(cmbPeregrino.SelectedValue.ToString()));
               // MessageBox.Show(nuevo.id_asistencia.ToString());
                nuevo.id_asistencia = int.Parse(txtCodigo.Text);
                actividades a = auxActi.buscar(actividadesList.Find(x => x.actividad.ToString().Contains(cmbActividad.selectedValue)).id_actividad);
                peregrinos p = auxPere.buscar(peregrinosList.Find(x => x.nombres.ToString().Contains(cmbPeregrino.selectedValue)).id_peregrino);
                nuevo.pre_asis = cbxPreAsistencia.Checked ? 1 : 0;
                nuevo.asis = cbxAsistencia.Checked ? 1 : 0;
                nuevo.id_actividad = a.id_actividad;
                nuevo.id_peregrino = p.id_peregrino;
                //p.asistencia.Add(nuevo);
                //a.asistencia.Add(nuevo);

                if (ADO.modificar(nuevo) == 1)
                {
                    MessageBox.Show("Asistencia modificada con exito :D");
                    cargar();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar: " + e.ToString());
                padre.mostrarAsistencia();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ADO.eliminar(int.Parse(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Asistencia eliminada con exito :D");
                cargar();
                limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            cbxAsistencia.Checked = true;
            cbxPreAsistencia.Checked = true;
            cmbActividad.selectedIndex = 0;
            cmbPeregrino.selectedIndex = 0;
            cmbActividad.ResetText();
            cmbPeregrino.ResetText();
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
                    cbxPreAsistencia.Checked = dataGridView1.CurrentRow.Cells[1].Value.ToString().Equals("SI");
                    cbxAsistencia.Checked = dataGridView1.CurrentRow.Cells[2].Value.ToString().Equals("SI");
                    int index = 0;
                    for (int i = 0; i >= -1; i++)
                    {
                        cmbActividad.selectedIndex = i;
                        //MessageBox.Show("Index: " + i + "   " + cmbActividad.selectedValue + "=" + dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        if (cmbActividad.selectedValue.Equals(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
                        {
                            index = i;
                            break;
                        }
                    }
                    cmbActividad.selectedIndex = index;
                    index = 0;
                    for (int i =0; i >= -1; i++ )
                    {
                        cmbPeregrino.selectedIndex = i;
                        //MessageBox.Show("Index: " + i + "   "+ cmbPeregrino.selectedValue+"=" + dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        if (cmbPeregrino.selectedValue.Equals(dataGridView1.CurrentRow.Cells[4].Value.ToString()))
                        {
                            index = i;
                            break;
                        }
                    }
                    cmbPeregrino.selectedIndex = index;
                    cmbActividad.Refresh();
                    cmbPeregrino.Refresh();
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            catch (Exception)
            {
                limpiar();
                //MessageBox.Show("Error al cargar cmb: " + e);
            }
        }

        private void frmAsistencias_VisibleChanged(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
