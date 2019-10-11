using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaDetalle.Entidades
{
    public class Asignatura
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }

        public Asignatura(int asignaturaId, string nombre)
        {
            AsignaturaId = asignaturaId;
            Nombre = nombre;
        }

        public Asignatura()
        {
        }
    }
}
