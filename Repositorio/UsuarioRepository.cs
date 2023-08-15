using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    internal sealed class UsuarioRepository : RepositoryBase<Usuario>,IusuarioRepository
    {
        public UsuarioRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public IEnumerable<Usuario> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        IEnumerable<Usuario> IusuarioRepository.GetAllEmployees(bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
