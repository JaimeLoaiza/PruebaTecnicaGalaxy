using PruebaTecnicaGalaxy.Models.Trabajador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaTecnicaGalaxy.Controllers
{
    public class UsuarioController : ApiController
    {
        public Respuesta Galaxy()
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.resultado = 1;
            oRespuesta.mensaje = "Trabajador Registrado";
            return oRespuesta;
        }
    }
}
