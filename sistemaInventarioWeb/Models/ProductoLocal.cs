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
    using System.Collections.Generic;
    
    public partial class ProductoLocal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductoLocal()
        {
            this.DetalleCompra = new HashSet<DetalleCompra>();
            this.DetalleVenta = new HashSet<DetalleVenta>();
        }
    
        public int id_stock { get; set; }
        public int cantidad { get; set; }
        public int id_producto { get; set; }
        public int id_local { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual Local Local { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
