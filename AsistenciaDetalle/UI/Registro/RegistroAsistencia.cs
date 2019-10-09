using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsistenciaDetalle.UI.Registro;

namespace AsistenciaDetalle.UI.Registro
{
    public partial class RegistroAsistencia : Form
    {
        public RegistroAsistencia()
        {
            InitializeComponent();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevoEstudianteButton_Click(object sender, EventArgs e)
        {
            Form registre = new RegistroEstudiantes();
            registre.Show();
        }
    }
}
