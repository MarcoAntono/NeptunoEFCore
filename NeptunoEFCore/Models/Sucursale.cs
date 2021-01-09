using System;
using System.Collections.Generic;

#nullable disable

namespace NeptunoEFCore.Models
{
    public partial class Sucursale
    {
        public Sucursale()
        {
            Empleados = new HashSet<Empleado>();
            Pedidos = new HashSet<Pedido>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string DepartamentoId { get; set; }
        public string ProvinciaId { get; set; }
        public string DistritoId { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Provincium Provincia { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
