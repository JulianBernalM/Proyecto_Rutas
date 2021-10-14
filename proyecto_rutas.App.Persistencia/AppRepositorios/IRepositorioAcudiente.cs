using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAcudiente
    {
         IEnumerable<Acudiente> GetAllAcudientes(string? nombre);
         Acudiente AddAcudiente(Acudiente acudiente);
         Acudiente UpdateAcudiente(Acudiente acudiente);
         void DeleteAcudiente(int idAcudiente);
         Acudiente GetAcudiente(int? idAcudiente);
    }
}