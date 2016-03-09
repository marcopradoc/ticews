using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class MaterialController : ApiController
    {

        ticeEntities3 objapi = new ticeEntities3();
        
        [HttpGet]
        public IEnumerable<SP_MATERIAL_RETRIEVE_Result> listarMaterialesPorTaller(int codigoTaller)
        {
            return objapi.SP_MATERIAL_RETRIEVE(codigoTaller).AsEnumerable();
        }

    }
}
