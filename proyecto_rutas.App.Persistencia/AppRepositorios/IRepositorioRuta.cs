using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRuta
    {
         IEnumerable<Ruta> GetAllRutas();
         Ruta AddRuta(Ruta ruta);
         Ruta UpdateRuta(Ruta ruta);
         void DeleteRuta(int idRuta);
         Ruta GetRuta(int idRuta);
    }
}