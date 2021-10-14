using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVehiculo
    {
         IEnumerable<Vehiculo> GetAllVehiculos();
         Vehiculo AddVehiculo(Vehiculo vehiculo);
         Vehiculo UpdateVehiculo(Vehiculo vehiculo);
         void DeleteVehiculo(int idVehiculo);
         Vehiculo GetVehiculo(int idVehiculo);
    }
}