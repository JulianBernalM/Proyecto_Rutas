using System;

namespace proyecto_rutas.App.Dominio.Entidades
{
    public class Acudiente
    {
        public int id { get; set; }
        public int numero_identificacion { get; set; }
        public string nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string fijo { get; set; }
        public string movil { get; set; }
        public string mail { get; set; }
        public string direccion { get; set; }
    }
}