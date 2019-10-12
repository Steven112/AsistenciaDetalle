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
using AsistenciaDetalle.UI.Consultas;

namespace AsistenciaDetalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registre = new rAsistencia ();
            registre.Show();

        }

        private void RegistroEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registre = new rEstudiantes();
            registre.Show();
        }

        private void RegistroAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registre = new rAsignatura();
            registre.Show();
        }

        private void ConsultaAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registre = new cAsistencia();
            registre.Show();

        }

        private void ConsultaEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registre = new cEstudiantes();
            registre.Show();
        }

        private void ConsultaAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registre = new cAsignatura();
            registre.Show();
        }
    }
}
