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
            cargar();
        }

        Asistencia ADO = new Asistencia();
        Actividades auxActi = new Actividades();
        Peregrino auxPere = new Peregrino();

        private void cargar()
        {
            this.LlenarData(ADO.getAsistencias());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            cmbActividad.DataSource = auxActi.getActividades();
            cmbActividad.DisplayMember = "actividad";
            cmbActividad.ValueMember = "id_actividad";
            cmbPeregrino.DataSource = auxPere.getPeregrinos();
            cmbPeregrino.DisplayMember = "nombres";
            cmbPeregrino.ValueMember = "id_peregrino";
        }

        private void LlenarData(List<asistencia> nueva)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in nueva)
            {
                dataGridView1.Rows.Add(item.id_asistencia, item.pre_asis == 1 ? "SI" : "NO", item.asis == 1 ? "SI" : "NO", item.actividades.actividad, item.peregrinos.nombres);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            asistencia nuevo = new asistencia();
            actividades a = auxActi.buscar(int.Parse(cmbActividad.SelectedValue.ToString()));
            peregrinos p = auxPere.buscar(int.Parse(cmbPeregrino.SelectedValue.ToString()));
            nuevo.pre_asis = cbxPreAsistencia.Checked ? 1 : 0;
            nuevo.asis = cbxAsistencia.Checked ? 1 : 0;
            nuevo.id_actividad = a.id_actividad;
            nuevo.id_peregrino = p.id_peregrino;
            p.asistencia.Add(nuevo);
            a.asistencia.Add(nuevo);
            if (ADO.guardar(nuevo) == 1)
            {
                MessageBox.Show("Asistencia agregada con exito :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            asistencia nuevo = new asistencia();
            actividades a = auxActi.buscar(int.Parse(cmbActividad.SelectedValue.ToString()));
            peregrinos p = auxPere.buscar(int.Parse(cmbPeregrino.SelectedValue.ToString()));
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
                MessageBox.Show("Asistencia eliminada con exito :D");
                cargar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error... Vuelva a intentarlo D:");
            }
        }
    }
}
