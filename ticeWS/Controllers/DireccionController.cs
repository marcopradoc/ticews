using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class DireccionController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_DIRECCION_LOAD_Result> listarTalleres()
        {
            return objapi.SP_DIRECCION_LOAD().AsEnumerable();
        }
    }
}