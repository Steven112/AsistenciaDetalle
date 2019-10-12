using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsistenciaDetalle.BLL;
using AsistenciaDetalle.Entidades;

namespace AsistenciaDetalle.UI.Consultas
{
    public partial class cAsistencia : Form
    {
        public cAsistencia()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asistencia>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedItem)
                {
                    case 0:
                        listado = AsistenciaBLL.GetList(p => true);
                        break;
                    case 1:
                        int Id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = AsistenciaBLL.GetList(p => p.AsistenciaId == Id);
                        break;
                    case 2:
                        listado = AsistenciaBLL.GetList(asistencia => asistencia.AsignaturaId == Convert.ToInt32(CriteriotextBox.Text));
                        break;


                }

                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();

            }
            else
            {
                listado =AsistenciaBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
