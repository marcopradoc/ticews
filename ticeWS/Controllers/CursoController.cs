using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class CursoController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_CURSO_LOAD_Result> listarTalleres(int codDireccion)
        {
            return objapi.SP_CURSO_LOAD(codDireccion).AsEnumerable();
        }
    }
}