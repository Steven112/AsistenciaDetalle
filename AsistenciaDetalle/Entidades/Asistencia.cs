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
        public virtual List<EstudiantesDetalle> Estudiante { get; set; }
        public int EstudianteId { get; set; }
        public virtual List<AsignaturaDetalle> Asignatura { get; set; }
        public int Cantidad { get; set; }
        public Asistencia()
        {
            AsistenciaId = 0;
            Fecha = DateTime.Now;
            Asignatura = new List<AsignaturaDetalle>();
            Estudiante = new List<EstudiantesDetalle>();
            AsignaturaId = 0;
            EstudianteId = 0;
            Cantidad = 0;

        }

    }
}
