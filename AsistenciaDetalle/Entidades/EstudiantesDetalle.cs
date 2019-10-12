using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaDetalle.Entidades
{
    public class EstudiantesDetalle
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }
        public int AsignaturaId { get; set; }
        public bool Presente { get; set; }

        public EstudiantesDetalle(int estudianteId, string nombres, int asignaturaId, bool presente)
        {
            EstudianteId = estudianteId;
            Nombres = nombres;
            AsignaturaId = asignaturaId;
            Presente = presente;
        }

        public EstudiantesDetalle()
        {
           
        }
    }
}
