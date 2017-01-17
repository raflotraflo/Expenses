using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expenses.Domain.Interfaces;
using Expenses.Domain.Models;

namespace Expenses.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IRepositoryContext context) : base (context)
        {
            
        }
    }
}
