using System;

namespace proyecto_rutas.App.Dominio.Entidades
{
    public class Vehiculo
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string capacidad { get; set; }
        public string matricula_placa { get; set; }
        public Conductor conductor { get; set; } 
        public Marca marca { get; set; } 
        public Ruta ruta { get; set; } 
    }
}