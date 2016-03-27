using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;
namespace ticeWS.Controllers
{
    public class SemanaController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_SEMANA_RETRIEVE_Result> obtenerActividad()
        {
            return objapi.SP_SEMANA_RETRIEVE().AsEnumerable();
        }
    }
}