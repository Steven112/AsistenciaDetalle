using AsistenciaDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Asistencia> Asistencias { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
    
}
