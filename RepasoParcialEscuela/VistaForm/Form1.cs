using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormVistaCurso : Form
    {
        Curso curso;
        Profesor profesor;
        Alumno alumno;

        public FormVistaCurso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Profesor.Divisiones division;
            Enum.TryParse<Profesor.Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);

            alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtLegajo.Text, (short)nudAño.Value, division);
            curso += alumno;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Profesor.Divisiones division;
            Enum.TryParse<Profesor.Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            profesor = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDniProfe.Text, dtpFechaIngreso.Value);
            //instanciar a un profesor con los datos pasados en los txt y fecha
            curso = new Curso((short)nudAñoCurso.Value, division, profesor);//instancio un curso año, la division, y el profesor ya instanciado

            MessageBox.Show("Curso creado Correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!(curso is null))
                rtbDatos.Text = (string)curso;
            else
                MessageBox.Show("No existe ningun curso", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormVistaCurso_Load(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Profesor.Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Profesor.Divisiones));
        }
    }
}
