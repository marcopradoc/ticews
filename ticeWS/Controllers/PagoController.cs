using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;


namespace ticeWS.Controllers
{
    public class PagoController : ApiController
    {

        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_GRUPOPAGO_LOAD_Result> listarPagos(string codPago)
        {

            return objapi.SP_GRUPOPAGO_LOAD().AsEnumerable();
        }
        [HttpGet]
        public IEnumerable<SP_TIPODOCUMENTO_LOAD_Result> listarDocumentos(string codDoc)
        {

            return objapi.SP_TIPODOCUMENTO_LOAD().AsEnumerable();
        }
        [HttpGet]
        public IEnumerable<SP_STRING_LOAD_Result> listarStrings(string codString)
        {

            return objapi.SP_STRING_LOAD().AsEnumerable();
        }
    }
}