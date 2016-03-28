using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class SedeController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_SEDE_RETRIEVE_Result> listarSedes()
        {
            return objapi.SP_SEDE_RETRIEVE().AsEnumerable();
        }
    }
}