using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ticeWS.Models
{
    public class ModuloModels
    {
    }

    public class ActividadViewModel
    {
        public Nullable<int> codigoActividad { get; set; }
        public Nullable<int> codigoCurso { get; set; }
        public Nullable<int> codigoTipoCurso { get; set; }
        public string titulo { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public Nullable<int> codigoSesion { get; set; }
        public Nullable<int> codigoEstado { get; set; }
        public string descripcion { get; set; }
        public string usuarioCreacion { get; set; }
        public Nullable<int> codigoModalidad { get; set; }
        public Nullable<int> codigoPeriodo { get; set; }
        public string usuarioModificacion { get; set; }


        public int? codUnidad { get; set; }

        public int? codSemana { get; set; }
    }

    public class CursoViewModel
    {
        public Nullable<int> codigoCurso { get; set; }
        public string nombreCurso { get; set; }
        public string estado { get; set; }
        public string observaciones { get; set; }
        public string usuarioCreacion { get; set; }
        public string usuarioModificacion { get; set; }

    }

    public class TareaViewModel
    {
        public Nullable<int> codigoTarea { get; set; }
        public Nullable<int> codigoCurso { get; set; }
        public Nullable<int> codigoActividad { get; set; }
        public string titulo { get; set; }
        public Nullable<int> codigoPrioridad { get; set; }
        public Nullable<int> codTipoRecurso { get; set; }
        public string estado { get; set; }
        public Nullable<int> porcentajeCompletado { get; set; }
        public Nullable<int> codigoRecurso { get; set; }
        public string descripcion { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public string usuarioCreacion { get; set; }
        public string usuarioModificacion { get; set; }
        public int? codigoTipoRecurso { get; set; }
    }

    public class DocumentoViewModel
    {
        public Nullable<int> codigoDocumento { get; set; }
        public Nullable<int> codigoCurso { get; set; }
        public Nullable<int> codigoActividad { get; set; }
        public Nullable<int> codigoTarea { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public Nullable<int> codigoTipoDocumento { get; set; }
        public string descripcion { get; set; }
        public string rutaDocumento { get; set; }
        public string estado { get; set; }
        public string usuarioCreacion { get; set; }
        public string usuarioModificacion { get; set; }
    }

    public class CapacitacionParticipanteViewModel
    {
        public Nullable<int> codigoDocente { get; set; }
        public Nullable<int> codigoCapacitacion { get; set; }
        public string nombreCompleto { get; set; }
        public Nullable<bool> enviarConvocatoria { get; set; }
    }

    public class CapacitacionViewModel
    {
        public Nullable<int> codigoCapacitacion { get; set; }
        public string nombre { get; set; }
        public bool certificado { get; set; }
        public Nullable<int> codigoPerido { get; set; }
        public string descripcion { get; set; }
        public string correoContacto { get; set; }
        public bool enviarNotificacion { get; set; }
        public Nullable<int> periodicidadEnvio { get; set; }
        public string fechaInicio { get; set; }
        public bool capacitacionActiva { get; set; }
        public Nullable<int> codigoTaller { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaModificacion { get; set; }
        public string usuarioCreacion { get; set; }
        public string usuarioModificacion { get; set; }
        public string lugar { get; set; }
        public string fechaInicioEnvio { get; set; }
        public string fechaCapacitacion { get; set; }
    }

    public class DetalleCapacitacionViewModel
    {
        public int? codDetalleCapacitacion { get; set; }
        public int? codCapacitacion { get; set; }
        public int? codTaller { get; set; }
        public string codAulaVirtual { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public int? codSede { get; set; }
        public string lugar { get; set; }
        public decimal? sesionesPresenciales { get; set; }
        public decimal? sesionesVirtuales { get; set; }
        public string fechaEnvioNotificacion { get; set; }

        public DateTime? fechaCreacion { get; set; }
    }
}