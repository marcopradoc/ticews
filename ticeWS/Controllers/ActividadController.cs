using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class ActividadController : ApiController
    {
        
        ticeEntities3 objapi = new ticeEntities3();

        [HttpPost]
        public int actualizaActividad(ActividadViewModel obj)
        {
            if (obj.codigoActividad != null)
            {
                return objapi.SP_ACTIVIDAD_UPDATE(obj.codigoActividad, obj.codigoCurso, obj.codUnidad, obj.codSemana, obj.titulo, obj.codigoEstado, obj.descripcion, obj.usuarioModificacion);
            }
            return objapi.SP_ACTIVIDAD_CREATE(obj.codigoCurso, obj.codUnidad, obj.codSemana, obj.titulo, obj.codigoEstado.ToString(), obj.descripcion, obj.usuarioCreacion);
        }
        
        [HttpGet]
        public IEnumerable<SP_ACTIVIDAD_RETRIEVE_BY_CURSO2_Result> listarCursosxPeriodo(string codigoCurso)
        {
            return objapi.SP_ACTIVIDAD_RETRIEVE_BY_CURSO2(codigoCurso).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_ACTIVIDAD_RETRIEVE_Result> obtenerActividad(string codigoCurso,int codigoActividad)
        {
            return objapi.SP_ACTIVIDAD_RETRIEVE(codigoActividad).AsEnumerable();
        }

        [HttpPost]
        public int eliminarActividad(string codigoCurso, int codigoActividad)
        {
            return objapi.SP_ACTIVIDAD_DELETE(codigoActividad);
        }
    }
}
