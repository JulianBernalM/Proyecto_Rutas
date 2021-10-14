using System;

namespace proyecto_rutas.App.Dominio.Entidades
{
    public class Ruta
    {
        public int id { get; set; }
        public string cupo_disponible { get; set; }
        public string cupo_asignado { get; set; }
        public string nombre_zona { get; set; }
        public Zona zona { get; set; }
    }
}