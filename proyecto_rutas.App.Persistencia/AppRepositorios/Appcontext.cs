using System;
using Microsoft.EntityFrameworkCore;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Acudiente> Acudientes { get; set; }

        public DbSet<Conductor> Conductores { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Ruta> Rutas { get; set; }
        
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=localhost; Database = Default; user id=sa; Password=1234; Initial Catalog = proyecto_rutas");
            }
        }
    }
}