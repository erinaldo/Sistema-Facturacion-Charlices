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
    
    public partial class Ordenes_Reservadas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordenes_Reservadas()
        {
            this.Detalles_Ordenes = new HashSet<Detalles_Ordenes>();
        }
    
        public int id { get; set; }
        public int id_cliente { get; set; }
        public bool estado { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalles_Ordenes> Detalles_Ordenes { get; set; }
    }
}
