﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsistenciaDetalle.DAL;
using AsistenciaDetalle.BLL;
using AsistenciaDetalle.Entidades;

namespace AsistenciaDetalle.UI.Registro
{
    public partial class rEstudiantes : Form
    {
        GenericDetalleBLL<EstudiantesDetalle> EstudianteGeneric;
        rAsistencia asistencia = new rAsistencia();
        public rEstudiantes()
        {
            EstudianteGeneric = new GenericDetalleBLL<EstudiantesDetalle>();
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox, "Campo Vacio");
                NombretextBox.Focus();
                paso = false;
            }

            return paso;
        }
        private EstudiantesDetalle LlenaClase()
        {
            EstudiantesDetalle estudiantes = new EstudiantesDetalle();
            estudiantes.EstudianteId= Convert.ToInt32(IDnumericUpDown1.Value);
            estudiantes.Nombres = NombretextBox.Text;

            return estudiantes;
        }

        private void LlenaCampos(EstudiantesDetalle estudiante)
        {
            IDnumericUpDown1.Value = estudiante.EstudianteId;
            NombretextBox.Text = estudiante.Nombres;
        }
        private bool ExisteBasedeDatos()
        {
            EstudiantesDetalle estudiantes =EstudianteGeneric.Buscar((int)IDnumericUpDown1.Value);

            return (estudiantes != null);
        }
        private void Limpiar()
        {
            IDnumericUpDown1.Value = 0;
            NombretextBox.Text = string.Empty;
        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            EstudiantesDetalle estudiantes = new EstudiantesDetalle();
            EstudianteGeneric = new GenericDetalleBLL<EstudiantesDetalle>();
            id = Convert.ToInt32(IDnumericUpDown1.Value);


            Limpiar();

            estudiantes = EstudianteGeneric.Buscar(id);

            if (estudiantes != null)
            {
                LlenaCampos(estudiantes);
            }
            
            asistencia.ComboBox();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            EstudiantesDetalle estudiante = new EstudiantesDetalle();
            bool paso = false;

            if (!Validar())
                return;

            estudiante = LlenaClase();


            if (IDnumericUpDown1.Value == 0)
                paso = EstudianteGeneric.Guardar(estudiante);
            else
            {
                if (!ExisteBasedeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EstudianteGeneric.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            asistencia.ComboBox();

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();

            int id;
            id = Convert.ToInt32(IDnumericUpDown1.Value);
            Contexto db = new Contexto();

            EstudiantesDetalle estudiantes = new EstudiantesDetalle();
            Limpiar();

            if (EstudianteGeneric.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MyerrorProvider.SetError(IDnumericUpDown1, "No se puede eliminar el estudiante");
            }
            asistencia.ComboBox();
        }
    }
}
