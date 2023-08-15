using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IusuarioRepository Usuario { get; }
        IProductosRepository Productos { get; }
        void Save();
    }
}
a