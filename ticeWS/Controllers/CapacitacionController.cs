using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class CapacitacionController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_CAPACITACION_RETRIEVE_BY_FILTER_Result> listarCapacitaciones(string codigoPeriodo, string nombreCapacitacion)
        {
            if (nombreCapacitacion == null)
            {
                nombreCapacitacion = "";
            }
            return objapi.SP_CAPACITACION_RETRIEVE_BY_FILTER(codigoPeriodo, nombreCapacitacion).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_CAPACITACION_RETRIEVE_Result> listarCapacitaciones(int codigoCapacitacion)
        {
            return objapi.SP_CAPACITACION_RETRIEVE(codigoCapacitacion).AsEnumerable();
        }

        [HttpPost]
        public int guardarCapacitacion(CapacitacionViewModel obj)
        {
            //Nullable<System.DateTime> fechaInicio = null;
            //Nullable<System.DateTime> fechaInicioEnvio = null;
            //Nullable<System.DateTime> fechaCapacitacion = null;
            Nullable<System.DateTime> fechaCreacion = null;
            Nullable<System.DateTime> fechaModificacion = null;

            //if (obj.fechaInicio != null && obj.fechaInicio.Length > 0)
            //{
            //    fechaInicio = DateTime.Parse(obj.fechaInicio);
            //}
            //if (obj.fechaInicioEnvio != null && obj.fechaInicioEnvio.Length > 0)
            //{
            //    fechaInicioEnvio = DateTime.Parse(obj.fechaInicioEnvio);
            //}
            //if (obj.fechaCapacitacion != null && obj.fechaCapacitacion.Length > 0)
            //{
            //    fechaCapacitacion = DateTime.Parse(obj.fechaCapacitacion);
            //}
            if (obj.fechaCreacion != null && obj.fechaCreacion.Length > 0)
            {
                fechaCreacion = DateTime.Parse(obj.fechaCreacion);
            }
            if (obj.fechaModificacion != null && obj.fechaModificacion.Length > 0)
            {
                fechaModificacion = DateTime.Parse(obj.fechaModificacion);
            }
            if (obj.codigoCapacitacion != null)
            {
                int cod = objapi.SP_CAPACITACION_UPDATE(obj.codigoCapacitacion,obj.nombre, obj.codigoPerido, obj.descripcion, obj.correoContacto, obj.enviarNotificacion, obj.periodicidadEnvio, obj.capacitacionActiva, fechaCreacion, fechaModificacion, obj.usuarioCreacion, obj.usuarioModificacion);
                return 1;
            }
            ObjectParameter codigoCapacitacion = new ObjectParameter("codigoCapacitacion", typeof(int));
            objapi.SP_CAPACITACION_CREATE(codigoCapacitacion, obj.nombre, obj.codigoPerido, obj.descripcion, obj.correoContacto, obj.enviarNotificacion, obj.periodicidadEnvio, obj.capacitacionActiva, fechaCreacion, fechaModificacion, obj.usuarioCreacion);
            return (int)codigoCapacitacion.Value;
        }

        [HttpPost]
        public int guardarMaterialCapacitacion(int codigoCapacitacion, string descripcion, string rutaDocumento)
        {
            return objapi.SP_MATERIAL_CAPACITACION_CREATE(codigoCapacitacion, descripcion, rutaDocumento);
        }

    }
}
