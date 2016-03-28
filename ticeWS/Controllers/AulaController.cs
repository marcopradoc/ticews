using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class AulaController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_AULA_RETRIEVE_Result> listarAulas()
        {
            return objapi.SP_AULA_RETRIEVE().AsEnumerable();
        }
    }
}