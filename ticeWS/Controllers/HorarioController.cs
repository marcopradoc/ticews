using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class HorarioController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_HORARIO_RETRIEVE_BY_CURSO_PERIODO_MODALIDAD_DOCENTE_Result> listarHorarioBy(string codCurso, int codModalidad, string semana, int codDocente)
        {
            return objapi.SP_HORARIO_RETRIEVE_BY_CURSO_PERIODO_MODALIDAD_DOCENTE(codCurso, codModalidad, semana, codDocente).AsEnumerable();
        }
    }
}