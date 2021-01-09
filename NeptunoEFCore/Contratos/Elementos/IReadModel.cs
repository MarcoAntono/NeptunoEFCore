using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeptunoEFCore.Contratos.Elementos
{
    public interface IReadModel <T>
    {
        Task< List<T>> GetAll();
        IEnumerable<T> Get(int value );
        IEnumerable<T> Get(String value);
    }
}
