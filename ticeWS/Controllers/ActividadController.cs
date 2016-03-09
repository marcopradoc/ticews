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
            DateTime fechaInicio = DateTime.Parse(obj.fechaInicio);
            DateTime fechaFin = DateTime.Parse(obj.fechaFin);
            if (obj.codigoActividad != null)
            {
                return objapi.SP_ACTIVIDAD_UPDATE(obj.codigoActividad, obj.codigoCurso, obj.codigoModalidad, obj.codigoPeriodo, obj.codigoTipoCurso, obj.titulo, fechaInicio, fechaFin, obj.codigoSesion, obj.codigoEstado, obj.descripcion, obj.usuarioModificacion);
            }
            return objapi.SP_ACTIVIDAD_CREATE(obj.codigoCurso, obj.codigoModalidad, obj.codigoPeriodo, obj.codigoTipoCurso, obj.titulo, fechaInicio, fechaFin, obj.codigoSesion, obj.codigoEstado, obj.descripcion, obj.usuarioCreacion);
        }
        
        [HttpGet]
        public IEnumerable<SP_ACTIVIDAD_RETRIEVE_BY_CURSO2_Result> listarCursosxPeriodo(int codigoCurso)
        {
            return objapi.SP_ACTIVIDAD_RETRIEVE_BY_CURSO2(codigoCurso).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_ACTIVIDAD_RETRIEVE_Result> obtenerActividad(int codigoCurso,int codigoActividad)
        {
            return objapi.SP_ACTIVIDAD_RETRIEVE(codigoActividad).AsEnumerable();
        }

        [HttpPost]
        public int eliminarActividad(int codigoCurso, int codigoActividad)
        {
            return objapi.SP_ACTIVIDAD_DELETE(codigoActividad);
        }
        //[HttpGet]
        //public string borrarActividad(int codigoActividad)
        //{
        //    try
        //    {
        //        objapi.SP_ACTIVIDAD_DELETE(codigoActividad);
        //        return "ok";
        //    }
        //    catch (Exception ex)
        //    {
        //        return "Error";

        //    }
        //}

        //[HttpGet]
        //public int listarActividadesxCurso(int codigoCurso, int codigoPeriodo, int codigoModalidad)
        //{

        //    return objapi.SP_ACTIVIDAD_RETRIEVE_BY_CURSO(codigoCurso, codigoPeriodo, codigoModalidad);

        //}
        
    }
}
