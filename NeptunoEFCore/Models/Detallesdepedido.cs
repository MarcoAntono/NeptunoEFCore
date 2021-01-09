using System;
using System.Collections.Generic;

#nullable disable

namespace NeptunoEFCore.Models
{
    public partial class Detallesdepedido
    {
        public int? Idpedido { get; set; }
        public int? Idproducto { get; set; }
        public decimal Preciounidad { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }

        public virtual Pedido IdpedidoNavigation { get; set; }
        public virtual Producto IdproductoNavigation { get; set; }
    }
}
