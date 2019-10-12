using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaDetalle.Entidades
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }

        public Estudiante()
        {
        }
        public Estudiante(int estudianteID, string nombre)
        {
            EstudianteId = estudianteID;
            Nombres = nombre;

        }
    }
}
