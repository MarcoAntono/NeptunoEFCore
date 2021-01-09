using System;
using System.Collections.Generic;

#nullable disable

namespace NeptunoEFCore.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Sucursales = new HashSet<Sucursale>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Sucursale> Sucursales { get; set; }
    }
}
