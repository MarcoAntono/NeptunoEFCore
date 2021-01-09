using System;
using System.Collections.Generic;

#nullable disable

namespace NeptunoEFCore.Models
{
    public partial class Compañiasdeenvio
    {
        public Compañiasdeenvio()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int IdCompañiaEnvios { get; set; }
        public string NombreCompañia { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
