using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeptunoEFCore.Contratos.Elementos
{
    public interface IWriteModel<T>
    {
        int Update(T dto );
        int Create(T dto);
    }
}
