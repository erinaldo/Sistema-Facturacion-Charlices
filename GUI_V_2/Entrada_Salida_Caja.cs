//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI_V_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entrada_Salida_Caja
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public double monto { get; set; }
        public string motivo { get; set; }
        public System.DateTime fecha { get; set; }
        public bool estado { get; set; }
        public bool tipo { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
