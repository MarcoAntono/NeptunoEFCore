using Microsoft.EntityFrameworkCore;
using NeptunoEFCore.Contratos.Elementos;
using NeptunoEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace NeptunoEFCore.Servicio
{
    //SOLID #4: Interface Segregation Principle con C#
    public class ProductoServices : IReadModel<Producto>
    {
        private readonly neptunoContext _neptunoContext = null;
        public ProductoServices(neptunoContext neptunoContext)
        {
            this._neptunoContext = neptunoContext;
        }

        public IEnumerable<Producto> Get(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> Get(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Producto>> GetAll()
        {
            //using System.Linq.Dynamic.Core;
            //datos.OrderBy("");
            return await this._neptunoContext.Productos.ToListAsync();
            //return this._neptunoContext.Productos.AsQueryable().OrderBy("NombreProducto").ToList();
        }

        

        //IEnumerable<ProductoServices> IReadModel<ProductoServices>.Get(int value)
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerable<ProductoServices> IReadModel<ProductoServices>.Get(string value)
        //{
        //    throw new NotImplementedException();
        //}

        //List<ProductoServices> IReadModel<ProductoServices>.GetAll()
        //{
        //    return this._neptunoContext.Productos.OrderBy(a => a.NombreProducto).ToList();
        //}
    }
}
