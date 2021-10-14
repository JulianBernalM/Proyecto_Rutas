using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContext _appContext;
        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }

        ///public Vehiculo AddVehiculo(Vehiculo Vehiculo) cambia version video con repecto a la guia del profe
        Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo)
        {
            var VehiculoAdicionado = _appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return VehiculoAdicionado.Entity;
        }

        void IRepositorioVehiculo.DeleteVehiculo(int idVehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.id == idVehiculo);
            if(VehiculoEncontrado == null)
            return;
            _appContext.Vehiculos.Remove(VehiculoEncontrado);
            _appContext.SaveChanges();

        }

        Vehiculo IRepositorioVehiculo.GetVehiculo(int idVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(p => p.id == idVehiculo);
        }

        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculos()
        {
            return _appContext.Vehiculos;
        }

       Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo vehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.id == vehiculo.id);
            if(VehiculoEncontrado!= null)
            {
                VehiculoEncontrado.matricula_placa = vehiculo.matricula_placa;
                VehiculoEncontrado.marca = vehiculo.marca;

                _appContext.SaveChanges();
            }
            return VehiculoEncontrado;
        }
    }
}