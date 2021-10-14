using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstudiante
    {
         IEnumerable<Estudiante> GetAllEstudiantes();
         Estudiante AddEstudiante(Estudiante estudiante);
         Estudiante UpdateEstudiante(Estudiante estudiante);
         void DeleteEstudiante(int idEstudiante);
         Estudiante GetEstudiante(int idEstudiante);
    }
}