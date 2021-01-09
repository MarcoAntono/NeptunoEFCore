using System;
using System.Collections.Generic;

#nullable disable

namespace NeptunoEFCore.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdProveedor { get; set; }
        public string NombreCompañia { get; set; }
        public string Nombrecontacto { get; set; }
        public string Cargocontacto { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string CodPostal { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Paginaprincipal { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
