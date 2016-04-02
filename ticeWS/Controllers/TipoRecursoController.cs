using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class TipoRecursoController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_TIPORECURSO_LOAD_Result> listarTiposRecursos()
        {
            return objapi.SP_TIPORECURSO_LOAD().AsEnumerable();
        }
    }
}