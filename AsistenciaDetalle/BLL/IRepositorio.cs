﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AsistenciaDetalle.DAL;

namespace AsistenciaDetalle.BLL
{
    public interface IRepositorio<T> where T: class
    {
        bool Guardar(T entity);
        bool Modificar(T entity);
        T Buscar(int id);
        bool Eliminar(int id);
        List<T> GetList(Expression<Func<T, bool>> expression);


    }
}
