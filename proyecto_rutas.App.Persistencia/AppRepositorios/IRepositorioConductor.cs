using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioConductor
    {
         IEnumerable<Conductor> GetAllConductores();
         Conductor AddConductor(Conductor conductor);
         Conductor UpdateConductor(Conductor conductor);
         void DeleteConductor (int idConductor);
         Conductor GetConductor(int idConductor);
    }
}