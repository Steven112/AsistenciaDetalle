﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsistenciaDetalle.BLL;
using AsistenciaDetalle.Entidades;

namespace AsistenciaDetalle.UI.Consultas
{
    public partial class cAsignatura : Form
    {
        public cAsignatura()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            GenericDetalleBLL<Asignatura> genericDetalleBLL = new GenericDetalleBLL<Asignatura>();
            var listado = new List<Asignatura>();
            Expression<Func<Asignatura, bool>> filtro = a => true;
            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedItem)
                {
                    case 0:
                        listado = genericDetalleBLL.GetList(p => true);
                        break;
                    case 1:
                        int Id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = genericDetalleBLL.GetList(p => p.AsignaturaId == Id);
                        break;
                    


                }

            }
            else
            {
                listado = genericDetalleBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
