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
    
    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            this.Facturas = new HashSet<Facturas>();
            this.Ordenes_Reservadas = new HashSet<Ordenes_Reservadas>();
        }
    
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre_completo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public byte tipo_cliente { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }
        public string cla_rnc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordenes_Reservadas> Ordenes_Reservadas { get; set; }
    }
}
