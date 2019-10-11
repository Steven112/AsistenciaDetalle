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
using AsistenciaDetalle.DAL;

namespace AsistenciaDetalle.UI.Registro
{
    public partial class rAsignatura : Form
    {
       
        GenericDetalleBLL<Asignatura> AsignaturaGeneric;
        public rAsignatura()
        {
            InitializeComponent();
            AsignaturaGeneric = new GenericDetalleBLL<Asignatura>();
        }
        private Asignatura LlenaClase()
        {
            Asignatura asignatura = new Asignatura();
            asignatura.AsignaturaId = Convert.ToInt32(IDnumericUpDown1.Value);
            asignatura.Nombre = NombretextBox.Text;

            return asignatura;
        }
        private bool Validar()
        {
            MyerrorProvider.Clear();
            bool paso = true;
           

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox, "El campo no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void LlenaCampos(Asignatura asignatura)
        {
            IDnumericUpDown1.Value = asignatura.AsignaturaId;
            NombretextBox.Text = asignatura.Nombre;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Asignatura asignatura = new Asignatura();
            bool paso = false;

            if (!Validar())
                return;

            asignatura = LlenaClase();


            if (IDnumericUpDown1.Value == 0)
                paso = AsignaturaGeneric.Guardar(asignatura);
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = AsignaturaGeneric.Modificar(asignatura);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar()
        {
            IDnumericUpDown1.Value = 0;
            NombretextBox.Text = string.Empty;
        }
        private bool ExisteEnBaseDeDatos()
        {
            Asignatura asignatura = AsignaturaGeneric.Buscar((int)IDnumericUpDown1.Value);
            return (asignatura!= null);
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(IDnumericUpDown1.Value);
            Asignatura asignatura = new Asignatura();
            AsignaturaGeneric = new GenericDetalleBLL<Asignatura>();
       
            Limpiar();

            asignatura = AsignaturaGeneric.Buscar(id);

            if (asignatura != null)
            {
                LlenaCampos(asignatura);
            }
            else
            {
                MessageBox.Show("Asignatura no encontrada");
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();

            int id;
            id = Convert.ToInt32(IDnumericUpDown1.Value);
            Contexto db = new Contexto();

            Asignatura asignatura = new Asignatura();

            Limpiar();

            if (AsignaturaGeneric.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MyerrorProvider.SetError(IDnumericUpDown1, "No se puede eliminar la asignatura");
            }
        }
    }
}
