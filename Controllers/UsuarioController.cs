using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PruebaTecnicaGalaxy.Models;
using PruebaTecnicaGalaxy.Models.Trabajador;

namespace PruebaTecnicaGalaxy.Controllers
{
    public class UsuarioController : ApiController
    {
        public Respuesta Galaxy()
        {
            Respuesta form;
            using (PruebaTecnicaGalaxyEntities db = new PruebaTecnicaGalaxyEntities())
            {
                form = (from r in db.trabajador
                        select new Respuesta
                        {
                               id = r.id,
                               tipo_identificacion = r.tipo_identificacion,
                               numero_identificacion = r.numero_identificacion,
                               primer_nombre = r.primer_nombre,
                               segundo_nombre = r.segundo_nombre,
                               primer_apellido = r.primer_apellido,
                               segundo_apellido = r.segundo_apellido,
                               fecha_nacimiento = r.fecha_nacimiento,
                               edad = r.edad
                        }).ToRespuesta();
            }
            return (form);
        }
    }
}
