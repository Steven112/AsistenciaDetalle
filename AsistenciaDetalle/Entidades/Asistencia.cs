using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaDetalle.Entidades
{
    public class Asistencia
    {
        [Key]
        public int AsistenciaId { get; set; }
        public DateTime Fecha { get; set; }
        public int AsignaturaId { get; set; }
        public int EstudianteId { get; set; }
        public virtual List<EstudiantesDetalle> Estudiantes { get; set; }
        public int Cantidad { get; set; }

        public Asistencia()
        {


        }
        public Asistencia(int asistenciaId, DateTime fecha, int asignaturaId, int estudianteId, List<EstudiantesDetalle> estudiantes, int cantidad)
        {
            AsistenciaId = asistenciaId;
            Fecha = fecha;
            AsignaturaId = asignaturaId;
            EstudianteId = estudianteId;
            Estudiantes = estudiantes;
            Cantidad = cantidad;
        }
    }
}
