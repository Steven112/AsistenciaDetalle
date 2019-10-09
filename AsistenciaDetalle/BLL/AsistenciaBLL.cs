using AsistenciaDetalle.DAL;
using AsistenciaDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaDetalle.BLL
{
    public class AsistenciaBLL
    {
        public static bool Guardar(Asistencia asistencia)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Asistencias.Add(asistencia) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Asistencia asistencia)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {//Buscar las entidades que no estan para removerlas
                var Anterior = db.Asistencias.Find(asistencia.AsistenciaId);
                foreach(var item in Anterior.Estudiantes)
                {
                    if (!asistencia.Estudiantes.Exists(d => d.EstudanteId == item.EstudanteId))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(asistencia).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Asistencias.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        
        public static Asistencia Buscar(int id)
        {

            Contexto db = new Contexto();
            Asistencia asistencia = new Asistencia();

            try
            {
                
                asistencia = db.Asistencias.Find(id);
                asistencia.Estudiantes.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return asistencia;

        }

        public static List<Asistencia> GetList(Expression<Func<Asistencia, bool>> asistencia)
        {
            List<Asistencia> Lista = new List<Asistencia>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Asistencias.Where(asistencia).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}

