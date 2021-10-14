using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly AppContext _appContext;
        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext = appContext;
        }

        
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var EstudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return EstudianteAdicionado.Entity;
        }

        void IRepositorioEstudiante.DeleteEstudiante(int idEstudiante)
        {
            var EstudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            if(EstudianteEncontrado == null)
            return;
            _appContext.Estudiantes.Remove(EstudianteEncontrado);
            _appContext.SaveChanges();

        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {
            return _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }

       Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante Estudiante)
        {
            var EstudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == Estudiante.id);
            if(EstudianteEncontrado!= null)
            {
                EstudianteEncontrado.numero_identificacion = Estudiante.numero_identificacion;
                EstudianteEncontrado.nombre = Estudiante.nombre;

                _appContext.SaveChanges();
            }
            return EstudianteEncontrado;
        }
    }
}