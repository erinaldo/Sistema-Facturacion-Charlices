//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI_V_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aperturas_Cajas
    {
        public int id { get; set; }
        public System.DateTime fecha { get; set; }
        public int id_usuario { get; set; }
        public double monto_inicial { get; set; }
        public bool cerrada { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
