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
    
    public partial class peregrinos
    {
        public peregrinos()
        {
            this.asistencia = new HashSet<asistencia>();
            this.usuarios = new HashSet<usuarios>();
        }
    
        public int id_peregrino { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string correo { get; set; }
        public string tele_casa { get; set; }
        public string tele_celu { get; set; }
        public string ministerio { get; set; }
        public string jmj { get; set; }
    
        public virtual ICollection<asistencia> asistencia { get; set; }
        public virtual ICollection<usuarios> usuarios { get; set; }
    }
}
