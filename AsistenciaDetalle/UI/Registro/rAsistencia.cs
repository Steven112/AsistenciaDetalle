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
using AsistenciaDetalle.BLL;
using AsistenciaDetalle.Entidades;
using AsistenciaDetalle.DAL;

namespace AsistenciaDetalle.UI.Registro
{
    public partial class rAsistencia : Form
    {
        public GenericDetalleBLL<EstudiantesDetalle> GenericEstudiante;
        public List<EstudiantesDetalle> DetalleEstudiante { get; set; }
        public GenericDetalleBLL<Estudiante> Estudent;

        public rAsistencia()
        {
            InitializeComponent();
            ComboBox();
            this.DetalleEstudiante = new List<EstudiantesDetalle>();
            this.GenericEstudiante = new GenericDetalleBLL<EstudiantesDetalle>();
            Estudent = new GenericDetalleBLL<Estudiante>();
            
            
        }
        private void CargarGrid()
        {
            AsistenciadataGridView.DataSource = null;
            AsistenciadataGridView.DataSource = this.DetalleEstudiante;
            //AsistenciadataGridView.DataSource = this.AsignaaturacomboBox.SelectedIndex;
        }

        private void Limpiar()
        {
            AsistenciaerrorProvider.Clear();

            AsistenciaIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            AsignaaturacomboBox.SelectedIndex = -1;
            EstudiantecomboBox.SelectedIndex = -1;
            PresentecheckBox.Checked = false;
            CantidadtextBox.Text = "0";
            this.DetalleEstudiante = new List<EstudiantesDetalle>();
            CargarGrid();

        }

        private bool Validar()
        {
            bool paso = true;
            AsistenciaerrorProvider.Clear();
            
            if (this.DetalleEstudiante.Count == 0)
            {
                AsistenciaerrorProvider.SetError(AsistenciadataGridView, "Debe Agregar algun Estudiante");
                EstudiantecomboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(AsistenciaIdnumericUpDown.Text))
            {
                AsistenciaerrorProvider.SetError(AsistenciaIdnumericUpDown, "Agregue un ID");
                AsistenciaIdnumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Asistencia LlenaClase()
        {
            Asistencia asistencia = new Asistencia();
            asistencia.AsistenciaId = Convert.ToInt32(AsistenciaIdnumericUpDown.Value);
            asistencia.AsignaturaId = AsignaaturacomboBox.SelectedIndex;
            asistencia.Fecha = FechadateTimePicker.Value;
            asistencia.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            asistencia.Estudiantes = this.DetalleEstudiante;
            return asistencia;
        }

        private void LlenaCampos(Asistencia asistencia)
        {
            AsistenciaIdnumericUpDown.Value = asistencia.AsistenciaId;
            FechadateTimePicker.Value = asistencia.Fecha;
            AsignaaturacomboBox.SelectedIndex = asistencia.AsignaturaId;
            this.DetalleEstudiante = asistencia.Estudiantes;
            CargarGrid();
            CantidadtextBox.Text = Convert.ToString(asistencia.Cantidad);

        }

        private int cantidad;
        private void NuevoEstudianteButton_Click(object sender, EventArgs e)
        {
            if (AsistenciadataGridView.DataSource != null)
                this.DetalleEstudiante = (List<EstudiantesDetalle>)AsistenciadataGridView.DataSource;

            //todo:nvalidar campos detalle
            //Agrega un nuevo detalle al datagrid

            string nombres = Estudent.Buscar(id:(int) EstudiantecomboBox.SelectedIndex + 1).Nombres;

            this.DetalleEstudiante.Add(
                new EstudiantesDetalle(

                    estudianteId: EstudiantecomboBox.SelectedIndex,
                    nombres:nombres,
                    asignsturaId: AsignaaturacomboBox.SelectedIndex,
                    presente: PresentecheckBox.Checked
                 
                    )
            );

            CargarGrid();
            cantidad += 1;
            CantidadtextBox.Text = cantidad.ToString();
           
      
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Asistencia asistencia = AsistenciaBLL.Buscar((int)AsistenciaIdnumericUpDown.Value);
            return (asistencia != null);
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if(AsistenciadataGridView.Rows.Count > 0 && AsistenciadataGridView.CurrentRow!=null)
            {
                DetalleEstudiante.RemoveAt(AsistenciadataGridView.CurrentRow.Index);
                CargarGrid();
                cantidad -= 1;
                CantidadtextBox.Text = cantidad.ToString();
            }

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            bool paso = false;

            if (!Validar())
                return;

            asistencia = LlenaClase();

            if (AsistenciaIdnumericUpDown.Value == 0)
            {
                paso = AsistenciaBLL.Guardar(asistencia);
            }
            else
            {
                if (ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = AsistenciaBLL.Modificar(asistencia);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ComboBox()
        {
            EstudiantecomboBox.DataSource = null;
            GenericDetalleBLL<Estudiante> Generic = new GenericDetalleBLL<Estudiante>();
            List<Estudiante> lista = Generic.GetList(p => true);
            EstudiantecomboBox.DataSource = lista;
            EstudiantecomboBox.DisplayMember = "Nombres";
            EstudiantecomboBox.ValueMember = "EstudianteId";

            AsignaaturacomboBox.DataSource = null;
            GenericDetalleBLL<Asignatura> GenericAsignaturas = new GenericDetalleBLL<Asignatura>();
            List<Asignatura> listaAsig = new List<Asignatura>();
            listaAsig = GenericAsignaturas.GetList(p => true);
            AsignaaturacomboBox.DataSource = listaAsig;
            AsignaaturacomboBox.DisplayMember = "Nombre";
            AsignaaturacomboBox.ValueMember = "AsignaturaID";

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            AsistenciaerrorProvider.Clear();
            Asistencia asistencia = new Asistencia();
            int id;
            id = Convert.ToInt32(AsistenciaIdnumericUpDown.Value);

            if (AsistenciaBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                AsistenciaerrorProvider.SetError(AsistenciaIdnumericUpDown, "No se puede eliminar registro que no existe");
            }
        }

        private void AgregarAsignaturabutton_Click(object sender, EventArgs e)
        {
            Form Asignatura = new rAsignatura();
            Asignatura.Show();
        }

        private void AgregarEstudiantebutton_Click(object sender, EventArgs e)
        {
            Form registre = new rEstudiantes();
            registre.Show();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Asistencia asistencia = new Asistencia();
            
            id = Convert.ToInt32(AsistenciaIdnumericUpDown.Value);

            Limpiar();
            
            if (id > 0)
            {
                asistencia = AsistenciaBLL.Buscar(id);
            }

            if (asistencia != null)
            {
                LlenaCampos(asistencia);
            }
           
        }

        private void RAsistencia_Load(object sender, EventArgs e)
        {
            ComboBox();
        }
    }
}
