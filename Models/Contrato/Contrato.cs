using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnicaGalaxy.Models.Contrato
{
    public class Contrato
    {
        public int id { get; set; }
        public string nombre_entidad { get; set; }
        public int numero_contrato { get; set; }
        public string trabajador_vinculado { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_finalizacion { get; set; }
    }
}