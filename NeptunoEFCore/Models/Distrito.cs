using System;
using System.Collections.Generic;

#nullable disable

namespace NeptunoEFCore.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Sucursales = new HashSet<Sucursale>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string ProvinceId { get; set; }
        public string DepartmentId { get; set; }

        public virtual ICollection<Sucursale> Sucursales { get; set; }
    }
}
