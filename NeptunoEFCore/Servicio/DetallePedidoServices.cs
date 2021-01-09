using NeptunoEFCore.Contratos.Elementos;
using NeptunoEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace NeptunoEFCore.Servicio
{
    public class DetallePedidoServices : IReadModel<Detallesdepedido>
    {
        private readonly neptunoContext _context = null;
        public DetallePedidoServices(neptunoContext context)
        {
            this._context = context;
        }

        public IEnumerable<Detallesdepedido> Get(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Detallesdepedido> Get(string value)
        {
            throw new NotImplementedException();
        }
        /**
         var blogs = context.Blogs
    .Include(e => e.Posts.Where(p => p.Title.Contains("Cheese")))
    .ToList();
         */
        public async Task<List<Detallesdepedido>> GetAll()
        {
            return await this._context.Detallesdepedidos.Include(a => a.IdproductoNavigation).ToListAsync();
        }
    }
}
