using Parrcial1_AP.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Parrcial1_AP.Entidades;
using System.Text;
using System.Threading.Tasks;


namespace Parrcial1_AP.BLL
{
    public class EstudianteBLL 
    {
        public static bool Guardar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.estudiante.Add(estudiantes) != null)

                    paso = db.SaveChanges() > 0;

            }
            catch (Exception )
            {
                
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(estudiante).State = EntityState.Modified;
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
                var eliminar = db.estudiante.Find(id);
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
        public static Estudiantes Buscar(int id)
        {
            Contexto db = new Contexto();
            Estudiantes estudiante = new Estudiantes();
            try
            {
                estudiante = db.estudiante.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }
            return estudiante;

        }
       
        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> estudiante)
        {
            List<Estudiantes> Lista = new List<Estudiantes>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.estudiante.Where(estudiante).ToList();

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
   
