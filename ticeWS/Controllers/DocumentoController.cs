using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ticeWS.Models;

namespace ticeWS.Controllers
{
    public class DocumentoController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_DOCUMENTO_RETRIEVE_BY_TAREA_Result> listarDocumentosxTarea(int tarea)
        {

            return objapi.SP_DOCUMENTO_RETRIEVE_BY_TAREA(tarea).AsEnumerable();
        }
        
        [HttpGet]
        public IEnumerable<SP_DOCUMENTO_RETRIEVE_Result> obtenerDocumento(int codigoCurso, int codigoActividad, int codigoTarea, int codigoDocumento)
        {
            return objapi.SP_DOCUMENTO_RETRIEVE(codigoDocumento).AsEnumerable();
        }

        [HttpPost]
        public int eliminarDocumento(int codigoCurso, int codigoActividad, int codigoTarea, int codigoDocumento)
        {
            return objapi.SP_DOCUMENTO_DELETE(codigoDocumento);
        }

        [HttpPost]
        public int actualizaDocumento(DocumentoViewModel obj)
        {
            if (obj.codigoDocumento.HasValue)
            {
                return objapi.SP_DOCUMENTO_UPDATE(obj.codigoDocumento,obj.codigoCurso, obj.codigoActividad, obj.codigoTarea, obj.titulo, obj.autor, obj.codigoTipoDocumento, obj.descripcion, obj.rutaDocumento, obj.estado, obj.usuarioModificacion);
            }
            return objapi.SP_DOCUMENTO_CREATE(obj.codigoCurso, obj.codigoActividad, obj.codigoTarea, obj.titulo, obj.autor, obj.codigoTipoDocumento, obj.descripcion, obj.rutaDocumento, obj.estado, obj.usuarioCreacion);
        }

    }
}
