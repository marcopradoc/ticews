﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class TareaController : ApiController
    {

        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_TAREA_RETRIEVE_BY_ACTIVIDAD_Result> listarTareaXActividad(int actividad)
        {
           
            return objapi.SP_TAREA_RETRIEVE_BY_ACTIVIDAD(actividad).AsEnumerable();
        }

        [HttpGet]
        public int ingresarTarea(int codigoCurso, int codigoActividad , string titulo, string estado, int porcentajecompletado, int codigoTipRec, int codigoRecuros ,string descripcion,DateTime fechaInicio,  DateTime fechaFin, string usuarioCreacion)
        {

            return objapi.SP_TAREA_CREATE(codigoCurso, codigoActividad, titulo,  estado,  porcentajecompletado, codigoTipRec, codigoRecuros, descripcion, fechaInicio,  fechaFin,  usuarioCreacion);


        }

        [HttpPost]
        public int actualizaTarea(TareaViewModel obj)
        {
            DateTime fechaInicio = DateTime.Parse(obj.fechaInicio);
            DateTime fechaFin = DateTime.Parse(obj.fechaFin);
            //obj.estado = obj.estado[0];
            if (obj.codigoTarea.HasValue)
            {
                return objapi.SP_TAREA_UPDATE(obj.codigoTarea, obj.codigoCurso, obj.codigoActividad, obj.titulo, obj.codigoPrioridad, obj.estado, obj.porcentajeCompletado, obj.codigoRecurso, obj.descripcion, fechaInicio, fechaFin, obj.usuarioModificacion);
            }
            return objapi.SP_TAREA_CREATE(obj.codigoCurso, obj.codigoActividad, obj.titulo, obj.estado, obj.porcentajeCompletado, obj.codigoTipoRecurso,obj.codigoRecurso, obj.descripcion, fechaInicio, fechaFin, obj.usuarioCreacion);
        }

        [HttpGet]
        public int actualizarTarea(int codigoCurso, int codigoActividad, string titulo, string estado, int porcentajecompletado, int codigoTipRec, int codigoRecuros, string descripcion, DateTime fechaInicio, DateTime fechaFin, string usuarioCreacion)
        {

            return objapi.SP_TAREA_CREATE(codigoCurso, codigoActividad, titulo, estado, porcentajecompletado, codigoTipRec, codigoRecuros, descripcion, fechaInicio, fechaFin, usuarioCreacion);

        }

        [HttpPost]
        public int actualizarTareaPost(int codigoCurso, int codigoActividad, string titulo, string estado, int porcentajecompletado, int codigoTipRec, int codigoRecuros, string descripcion, DateTime fechaInicio, DateTime fechaFin, string usuarioCreacion)
        {
            return objapi.SP_TAREA_CREATE(codigoCurso, codigoActividad, titulo, estado, porcentajecompletado, codigoTipRec, codigoRecuros, descripcion, fechaInicio, fechaFin, usuarioCreacion);
        }

        [HttpGet]
        public IEnumerable<SP_TAREA_RETRIEVE_Result> obtenerTarea(int codigoCurso, int codigoActividad, int codigoTarea)
        {
            return objapi.SP_TAREA_RETRIEVE(codigoTarea).AsEnumerable();
        }

        [HttpPost]
        public int eliminarTarea(int codigoCurso, int codigoActividad, int codigoTarea)
        {
            return objapi.SP_TAREA_DELETE(codigoTarea);
        }

        [HttpGet]
        public IEnumerable<SP_TAREAS_RETRIEVE_BY_ACTAS_Result> listarTareaXActividad(int codModalidad, string estadoTarea, int estadoActa)
        {

            return objapi.SP_TAREAS_RETRIEVE_BY_ACTAS(codModalidad, estadoTarea, estadoActa).AsEnumerable();
        }
    }
}
