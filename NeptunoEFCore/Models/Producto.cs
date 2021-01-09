using System;
using System.Collections.Generic;

#nullable disable

namespace NeptunoEFCore.Models
{
    public partial class Producto
    {
        public int Idproducto { get; set; }
        public string NombreProducto { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdCategoria { get; set; }
        public string CantidadPorUnidad { get; set; }
        public decimal? PrecioUnidad { get; set; }
        public short? UnidadesEnExistencia { get; set; }
        public short? UnidadesEnPedido { get; set; }
        public short? NivelNuevoPedido { get; set; }
        public short? Suspendido { get; set; }
        public string CategoriaProducto { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Proveedore IdProveedorNavigation { get; set; }
    }
}
