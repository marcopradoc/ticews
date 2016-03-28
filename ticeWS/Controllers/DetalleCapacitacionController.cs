using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class DetalleCapacitacionController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpPost]
        public int actualizaDetalleCapacitacion(DetalleCapacitacionViewModel obj)
        {
            //return 1;
            Nullable<System.DateTime> fechaInicio = null;
            Nullable<System.DateTime> fechaFin = null;
            Nullable<System.DateTime> fechaEnvioNotificacion = null;

            if (obj.fechaInicio != null && obj.fechaInicio.Length > 0)
            {
                fechaInicio = DateTime.Parse(obj.fechaInicio);
            }
            if (obj.fechaFin != null && obj.fechaFin.Length > 0)
            {
                fechaFin = DateTime.Parse(obj.fechaFin);
            }
            if (obj.fechaEnvioNotificacion != null && obj.fechaEnvioNotificacion.Length > 0)
            {
                fechaEnvioNotificacion = DateTime.Parse(obj.fechaEnvioNotificacion);
            }
            if (obj.codDetalleCapacitacion != 0)
            {
                return objapi.SP_DETALLECAPACITACION_UPDATE(obj.codDetalleCapacitacion, obj.codCapacitacion, obj.codTaller, obj.codAulaVirtual, fechaInicio, fechaFin, obj.codSede, obj.lugar, obj.sesionesPresenciales, obj.sesionesVirtuales, fechaEnvioNotificacion, obj.fechaCreacion);
            }
            return objapi.SP_DETALLE_CAPACITACION_CREATE(obj.codCapacitacion, obj.codTaller, obj.codAulaVirtual, fechaInicio, fechaFin, obj.codSede, obj.lugar, obj.sesionesPresenciales, obj.sesionesVirtuales, fechaEnvioNotificacion);
        }

        [HttpGet]
        public IEnumerable<SP_DETALLECAPACITACION_RETRIEVE_Result> listarDetalleCapacitacion(int codDetalleCapacitacion)
        {
            return objapi.SP_DETALLECAPACITACION_RETRIEVE(codDetalleCapacitacion).AsEnumerable();
        }
    }
}