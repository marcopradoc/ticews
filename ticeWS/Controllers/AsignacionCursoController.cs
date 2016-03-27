using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class AsignacionCursoController : ApiController
    {

        ticeEntities3 objapi = new ticeEntities3();

        //    ticeEntities objapi = new ticeEntities();

        //    [HttpGet]
        //    public int asignarCurso(int codigoAsignacionCurso)
        //    {

        //        return objapi.SP_ASIGNACION_CURSO_LOAD(codigoAsignacionCurso);
        //    }

        //    [HttpGet]
        //    public int asignacionCursoRetrieve()
        //    {

        //        return objapi.SP_ASIGNACIONCURSO_RETRIEVE();
        //    }

        //    [HttpGet]
        //    public int asignacionRetrievexDocente(int codigoDocente)
        //    {

        //        return objapi.SP_ASIGNACIONCURSO_RETRIEVE_BY_DOCENTE(codigoDocente);
        //    }
        [HttpGet]
        public IEnumerable<SP_ACTIVIDAD_RETRIEVE_BY_CURSO_Result> listarCursosxPeriodo(string periodo, string estado)
        {
            if (periodo == null)
                periodo = "";

            if (estado == null)
                estado = "";

            return objapi.SP_ACTIVIDAD_RETRIEVE_BY_CURSO(periodo, estado).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_ACTIVIDAD_RETRIEVE_BY_CURSO3_Result> listarCursosxPeriodo(int? idperiodo, string estado)
        {
            if (idperiodo == null)
                idperiodo = 0;

            if (estado == null)
                estado = "";

            return objapi.SP_ACTIVIDAD_RETRIEVE_BY_CURSO3(idperiodo, estado).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_CURSO_RETRIEVE_Result> loadCurso(int codigo)
        {
            return objapi.SP_CURSO_RETRIEVE(codigo).AsEnumerable();
        }

        [HttpPost]
        public int editarCurso(CursoViewModel obj)
        {
            return objapi.SP_CURSO_UPDATE(obj.codigoCurso, obj.nombreCurso, obj.estado, obj.observaciones, obj.usuarioModificacion);
        }

    }
}
