﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CRUD_MODEL : DbContext
    {
        public CRUD_MODEL()
            : base("name=CRUD_MODEL")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Suplidores> Suplidores { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Unidades_medidas> Unidades_medidas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Combrobantes> Combrobantes { get; set; }
        public virtual DbSet<Metodos_Pagos> Metodos_Pagos { get; set; }
        public virtual DbSet<Detalles_Facturas> Detalles_Facturas { get; set; }
    
        public virtual ObjectResult<FACT_Result> FACT(Nullable<int> cODIGOFACT)
        {
            var cODIGOFACTParameter = cODIGOFACT.HasValue ?
                new ObjectParameter("CODIGOFACT", cODIGOFACT) :
                new ObjectParameter("CODIGOFACT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FACT_Result>("FACT", cODIGOFACTParameter);
        }
    }
}
