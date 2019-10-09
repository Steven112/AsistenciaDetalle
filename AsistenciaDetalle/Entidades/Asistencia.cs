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
     
        public virtual List<EstudiantesDetalle> Estudiantes { get; set; }
        public virtual List<AsignaturaDetalle>Asignatura { get; set; }
        public int Cantidad { get; set; }
        public Asistencia()
        {
            AsistenciaId = 0;
            Fecha = DateTime.Now;
            Asignatura = new List<AsignaturaDetalle>();
            Estudiantes = new List<EstudiantesDetalle>();
            Cantidad = 0;

        }

    }
}
