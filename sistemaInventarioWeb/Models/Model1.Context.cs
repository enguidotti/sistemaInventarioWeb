//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemaInventarioWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ventasdbEntities : DbContext
    {
        public ventasdbEntities()
            : base("name=ventasdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompra { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoLocal> ProductoLocal { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
    }
}
