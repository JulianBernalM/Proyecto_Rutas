using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public class RepositorioConductor : IRepositorioConductor
    {
        private readonly AppContext _appContext;
        public RepositorioConductor(AppContext appContext)
        {
            _appContext = appContext;
        }

        ///public Acudiente AddAcudiente(Acudiente acudiente) cambia version video con repecto a la guia del profe
        Conductor IRepositorioConductor.AddConductor(Conductor conductor)
        {
            var conductorAdicionado = _appContext.Conductores.Add(conductor);
            _appContext.SaveChanges();
            return conductorAdicionado.Entity;
        }

        void IRepositorioConductor.DeleteConductor(int idConductor)
        {
            var ConductorEncontrado = _appContext.Conductores.FirstOrDefault(p => p.id == idConductor);
            if(ConductorEncontrado == null)
            return;
            _appContext.Conductores.Remove(ConductorEncontrado);
            _appContext.SaveChanges();

        }

        Conductor IRepositorioConductor.GetConductor(int idConductor)
        {
            return _appContext.Conductores.FirstOrDefault(p => p.id == idConductor);
        }

        IEnumerable<Conductor> IRepositorioConductor.GetAllConductores()
        {
            return _appContext.Conductores;
        }

       Conductor IRepositorioConductor.UpdateConductor(Conductor conductor)
        {
            var ConductorEncontrado = _appContext.Conductores.FirstOrDefault(p => p.id == conductor.id);
            if(ConductorEncontrado!= null)
            {
                ConductorEncontrado.numero_identificacion = conductor.numero_identificacion;
                ConductorEncontrado.nombre = conductor.nombre;

                _appContext.SaveChanges();
            }
            return ConductorEncontrado;
        }
    }
}