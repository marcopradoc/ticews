using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class FocusGroupController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_FOCUSGROUP_RETRIEVE_BY_CURSO_ESTADO_Result> listarFocusGroup(string codCurso, string estado)
        {
            return objapi.SP_FOCUSGROUP_RETRIEVE_BY_CURSO_ESTADO(codCurso, estado).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_FOCUSGROUP_RETRIEVE_BY_CURSO_Result> listarFocusGroup(string codCurso)
        {
            return objapi.SP_FOCUSGROUP_RETRIEVE_BY_CURSO(codCurso).AsEnumerable();
        }
    }
}