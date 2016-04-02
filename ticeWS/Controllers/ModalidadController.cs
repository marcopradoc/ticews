using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class ModalidadController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_MODALIDAD_LOAD_Result> listarModalidades()
        {
            return objapi.SP_MODALIDAD_LOAD().AsEnumerable();
        }
    }
}