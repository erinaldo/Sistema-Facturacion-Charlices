﻿//------------------------------------------------------------------------------
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
        public virtual DbSet<Combrobantes> Combrobantes { get; set; }
        public virtual DbSet<Detalles_Facturas> Detalles_Facturas { get; set; }
        public virtual DbSet<Detalles_Ordenes> Detalles_Ordenes { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Metodos_Pagos> Metodos_Pagos { get; set; }
        public virtual DbSet<Ordenes_Reservadas> Ordenes_Reservadas { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Suplidores> Suplidores { get; set; }
        public virtual DbSet<Unidades_medidas> Unidades_medidas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Aperturas_Cajas> Aperturas_Cajas { get; set; }
        public virtual DbSet<Entrada_Salida_Caja> Entrada_Salida_Caja { get; set; }
        public virtual DbSet<Cierre_Caja> Cierre_Caja { get; set; }
    
        public virtual ObjectResult<FACT_Result> FACT(Nullable<int> cODIGOFACT)
        {
            var cODIGOFACTParameter = cODIGOFACT.HasValue ?
                new ObjectParameter("CODIGOFACT", cODIGOFACT) :
                new ObjectParameter("CODIGOFACT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FACT_Result>("FACT", cODIGOFACTParameter);
        }
    
        public virtual int Total_Caja(string accion_proceso, Nullable<int> id_usuario)
        {
            var accion_procesoParameter = accion_proceso != null ?
                new ObjectParameter("accion_proceso", accion_proceso) :
                new ObjectParameter("accion_proceso", typeof(string));
    
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Total_Caja", accion_procesoParameter, id_usuarioParameter);
        }
    
        public virtual ObjectResult<Total_Caja_Result> Procedimiento_total_caja(string accion_proceso, Nullable<int> id_usuario)
        {
            var accion_procesoParameter = accion_proceso != null ?
                new ObjectParameter("accion_proceso", accion_proceso) :
                new ObjectParameter("accion_proceso", typeof(string));
    
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Total_Caja_Result>("Procedimiento_total_caja", accion_procesoParameter, id_usuarioParameter);
        }
    
        public virtual ObjectResult<Resumen_caja_Result> Resumen_caja()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Resumen_caja_Result>("Resumen_caja");
        }
    }
}
