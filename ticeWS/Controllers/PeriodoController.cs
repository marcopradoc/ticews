using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class PeriodoController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        // GET: Periodo
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IEnumerable<SP_PERIODO_RETRIEVE_Result> loadPeriodo()
        {
            return objapi.SP_PERIODO_RETRIEVE().AsEnumerable();
        }
    }
}