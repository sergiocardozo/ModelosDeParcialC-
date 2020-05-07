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

namespace VistaForma
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;
        public FormDT()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)nudEdad.Value, (int)nudDni.Value, (int)nudExperiencia.Value);

            MessageBox.Show("Se ha creado el DT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void butttonValidar_Click(object sender, EventArgs e)
        {
            if (dt is null)
                MessageBox.Show("El DT no se ha creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (dt.ValidarAptitud())
                    MessageBox.Show("El DT es apto para dirigir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("El DT no es apto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDT_Load(object sender, EventArgs e)
        {

        }
    }
}
