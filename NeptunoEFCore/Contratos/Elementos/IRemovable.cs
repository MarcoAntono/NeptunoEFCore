using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeptunoEFCore.Contratos.Elementos
{
   public interface IRemovable<T>
    {
        bool EliminarModelo(T datos);
    }
}
