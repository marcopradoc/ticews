using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class CapacitacionParticipanteController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_PARTICIPANTES_CAPACITACION_RETRIEVE_BY_CAPACITACION_Result> listarParticipantes(int codigoCapacitacion)
        {
            return objapi.SP_PARTICIPANTES_CAPACITACION_RETRIEVE_BY_CAPACITACION(codigoCapacitacion).AsEnumerable();
        }

        [HttpPost]
        public int agregarParticipante(CapacitacionParticipanteViewModel obj)
        {
            return objapi.SP_PARTICIPANTES_CAPACITACION_CREATE(obj.codigoDocente, obj.codigoCapacitacion, obj.nombreCompleto, obj.enviarConvocatoria);
        }

        [HttpPost]
        public int quitarParticipante(int codigoCapacitacion,int codigoDocente)
        {
            return objapi.SP_PARTICIPANTES_CAPACITACION_DELETE(codigoCapacitacion, codigoDocente);
        }

    }
}
