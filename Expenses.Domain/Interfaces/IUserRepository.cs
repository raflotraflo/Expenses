using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expenses.Domain.Models;

namespace Expenses.Domain.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

        void SaveChanges();
    }
}
