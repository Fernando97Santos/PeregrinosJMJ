//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeregrinosJMJ
{
    using System;
    using System.Collections.Generic;
    
    public partial class asistencia
    {
        public int id_asistencia { get; set; }
        public Nullable<int> pre_asis { get; set; }
        public Nullable<int> asis { get; set; }
        public int id_actividad { get; set; }
        public int id_peregrino { get; set; }
    
        public virtual actividades actividades { get; set; }
        public virtual peregrinos peregrinos { get; set; }
    }
}
