//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ticeWS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Capacitacion
    {
        public int codCapacitacion { get; set; }
        public string nombre { get; set; }
        public Nullable<int> codPeriodo { get; set; }
        public string descripcion { get; set; }
        public string correoContacto { get; set; }
        public Nullable<bool> enviarNotificacion { get; set; }
        public Nullable<int> periodicidadEnvio { get; set; }
        public Nullable<bool> capacitacionActiva { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaModificacióm { get; set; }
        public string usuarioCreacion { get; set; }
        public string usuarioModificacion { get; set; }
    }
}
