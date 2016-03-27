using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class CapacitacionMaterialController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        //[HttpGet]
        //public IEnumerable<SP_MATERIAL_CAPACITACION_RETRIEVE_BY_CAPACITACION_Result> listarCapacitacionMaterial(int codigoCapacitacion)
        //{
        //    return objapi.SP_MATERIAL_CAPACITACION_RETRIEVE_BY_CAPACITACION(codigoCapacitacion).AsEnumerable();
        //}

    }
}
