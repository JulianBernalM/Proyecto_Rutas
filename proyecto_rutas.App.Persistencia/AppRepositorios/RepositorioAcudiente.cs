using System;
using System.Collections.Generic;
using System.Linq;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public class RepositorioAcudiente : IRepositorioAcudiente
    {
        private readonly AppContext _appContext;
        public IEnumerable<Acudiente> acudientes {get; set;} 

        public RepositorioAcudiente(AppContext appContext)
        {
            _appContext = appContext;
        }

        ///public Acudiente AddAcudiente(Acudiente acudiente) cambia version video con repecto a la guia del profe
        Acudiente IRepositorioAcudiente.AddAcudiente(Acudiente acudiente)
        {
            try{
                var AcudienteAdicionado = _appContext.Acudientes.Add(acudiente);
            _appContext.SaveChanges();
            return AcudienteAdicionado.Entity;
            }catch
          {
                throw;
          }            
        }

        void IRepositorioAcudiente.DeleteAcudiente(int idAcudiente)
        {
            var AcudienteEncontrado = _appContext.Acudientes.FirstOrDefault(p => p.id == idAcudiente);
            if(AcudienteEncontrado == null)
            return;
            _appContext.Acudientes.Remove(AcudienteEncontrado);
            _appContext.SaveChanges();

        }

        Acudiente IRepositorioAcudiente.GetAcudiente(int? idAcudiente)
        {
            return _appContext.Acudientes.FirstOrDefault(p => p.id == idAcudiente);
        }

        IEnumerable<Acudiente> IRepositorioAcudiente.GetAllAcudientes(string? nombre)
        {
            if (nombre != null) {
              acudientes = _appContext.Acudientes.Where(p => p.nombre.Contains(nombre));
            }
            else 
               acudientes = _appContext.Acudientes;
            return acudientes;
        }

       Acudiente IRepositorioAcudiente.UpdateAcudiente(Acudiente acudiente)
        {
            var AcudienteEncontrado = _appContext.Acudientes.FirstOrDefault(p => p.id == acudiente.id);
            if(AcudienteEncontrado!= null)
            {
                AcudienteEncontrado.numero_identificacion = acudiente.numero_identificacion;
                AcudienteEncontrado.nombre = acudiente.nombre;
                AcudienteEncontrado.primer_apellido = acudiente.primer_apellido;
                AcudienteEncontrado.segundo_apellido = acudiente.segundo_apellido;
                AcudienteEncontrado.fijo = acudiente.fijo;

                _appContext.SaveChanges();
            }
            return AcudienteEncontrado;
        }
    }
}