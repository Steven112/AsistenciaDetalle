﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaDetalle.Entidades
{
    public class AsignaturaDetalle
    {
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }
        public AsignaturaDetalle()
        {
            AsignaturaId = 0;
            Nombre = string.Empty;
        }
    }
}