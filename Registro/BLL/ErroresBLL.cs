using Microsoft.EntityFrameworkCore;
using Registro.DAL;
using Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Registro.BLL
{
    public class ErroresBLL
    {
        public static bool Guardar(Errores error)
        {
            if (!Existe(error.ErrorId))
                return Insertar(error);
            else
                return Modificar(error);
        }

        private static bool Insertar(Errores error)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Errores.Add(error);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
    
        public static bool Modificar(Errores error)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(error).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

       
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var estudiante = contexto.Errores.Find(id);

                if (estudiante != null)
                {
                    contexto.Errores.Remove(estudiante);//remover la entidad
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Errores Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Errores estudiante;

            try
            {
                estudiante = contexto.Errores.Find(id);
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }

            return estudiante;
        }

        public static List<Errores> GetList(Expression<Func<Errores, bool>> criterio)
        {
            List<Errores> lista = new List<Errores>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Errores.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Errores.Any(e => e.ErrorId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Errores> GetEstudiante()
        {
            List<Errores> lista = new List<Errores>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Errores.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

    }
}
