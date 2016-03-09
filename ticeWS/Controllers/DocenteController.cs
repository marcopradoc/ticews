using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class DocenteController : ApiController
    {

        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_DOCENTE_RETRIEVE_Result> listar()
        {
            return objapi.SP_DOCENTE_RETRIEVE().AsEnumerable();
        }

    }
}
