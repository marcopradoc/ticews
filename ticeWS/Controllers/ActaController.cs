using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;


namespace ticeWS.Controllers
{
    public class ActaController : ApiController
    {

        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_ACTAINFO_RETRIVE_BY_PROVEEDOR_Result> listarEstadosTarea(int codProveedor)
        {

            return objapi.SP_ACTAINFO_RETRIVE_BY_PROVEEDOR(codProveedor).AsEnumerable();
        }
    }
}