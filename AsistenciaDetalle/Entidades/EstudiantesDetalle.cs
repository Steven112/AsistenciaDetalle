using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaDetalle.Entidades
{
    public class EstudiantesDetalle
    {
        public int EstudanteId { get; set; }
        public string Nombres { get; set; }


        public EstudiantesDetalle()
        {
            EstudanteId = 0;
            Nombres = string.Empty;
        }
    }
}
