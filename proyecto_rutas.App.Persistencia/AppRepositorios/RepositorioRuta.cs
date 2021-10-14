using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public class RepositorioRuta : IRepositorioRuta
    {
        private readonly AppContext _appContext;
        public RepositorioRuta(AppContext appContext)
        {
            _appContext = appContext;
        }

        
        Ruta IRepositorioRuta.AddRuta(Ruta ruta)
        {
            var RutaAdicionado = _appContext.Rutas.Add(ruta);
            _appContext.SaveChanges();
            return RutaAdicionado.Entity;
        }

        void IRepositorioRuta.DeleteRuta(int idRuta)
        {
            var RutaEncontrado = _appContext.Rutas.FirstOrDefault(p => p.id == idRuta);
            if(RutaEncontrado == null)
            return;
            _appContext.Rutas.Remove(RutaEncontrado);
            _appContext.SaveChanges();

        }

        Ruta IRepositorioRuta.GetRuta(int idRuta)
        {
            return _appContext.Rutas.FirstOrDefault(p => p.id == idRuta);
        }

        IEnumerable<Ruta> IRepositorioRuta.GetAllRutas()
        {
            return _appContext.Rutas;
        }

       Ruta IRepositorioRuta.UpdateRuta(Ruta ruta)
        {
            var RutaEncontrado = _appContext.Rutas.FirstOrDefault(p => p.id == ruta.id);
            if(RutaEncontrado!= null)
            {
                RutaEncontrado.id = ruta.id;
                RutaEncontrado.nombre_zona = ruta.nombre_zona;

                _appContext.SaveChanges();
            }
            return RutaEncontrado;
        }
    }
}
