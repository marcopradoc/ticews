using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class TallerController : ApiController
    {

        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_TALLER_RETRIEVE_Result> listarTalleres()
        {
            return objapi.SP_TALLER_RETRIEVE().AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_TALLER_RETRIEVE_BY_TALLER_Result> obtenerTaller(int codigoTaller)
        {
            return objapi.SP_TALLER_RETRIEVE_BY_TALLER(codigoTaller).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_TALLER_RETRIEVE_BY_CAPACITACION_Result> obtenerTallerCapacitacion(int codigoCapacitacion)
        {
            return objapi.SP_TALLER_RETRIEVE_BY_CAPACITACION(codigoCapacitacion).AsEnumerable();
        }

    }
}
