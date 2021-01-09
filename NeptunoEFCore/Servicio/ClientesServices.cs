using Microsoft.EntityFrameworkCore;
using NeptunoEFCore.Contratos.Elementos;
using NeptunoEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeptunoEFCore.Servicio
{
    public class ClientesServices : IReadModel<Cliente>
    {

        private readonly neptunoContext _context = null;
        public ClientesServices(neptunoContext context)
        {
            this._context = context;
        }

        public IEnumerable<Cliente> Get(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Get(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await this._context.Clientes.Include(a => a.Pedidos).ToListAsync();
        }

        public async Task<List<Cliente>> GetFindPais(String values)
        {
            return await this._context.Clientes.Where(a=> a.Pais== values).ToListAsync();
        }

        /*
         var query = context.People
            .GroupBy(p => p.name)
            .Select(g => new { name = g.Key, count = g.Count() });
        */

        public IEnumerable<object> GetCountPais()
        {
            var datos = this._context.Clientes
                .GroupBy(x => x.Pais)
                .Select(g => new { Pais = g.Key, count = g.Count() }).ToList();
            return datos.ToList();
        }

    }
}
