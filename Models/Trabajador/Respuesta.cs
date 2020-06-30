using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnicaGalaxy.Models.Trabajador
{
    public class Respuesta
    {
        public int id { get; set; }
        public string tipo_identificacion { get; set; }
        public string numero_identificacion { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public int edad { get; set; }
    }
}