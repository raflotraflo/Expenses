using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expenses.Domain.Interfaces;
using Expenses.Domain.Models;

namespace Expenses.Repository
{
    public class UserRepository : IUserRepository
    {
        private IRepositoryContext _db;

        public UserRepository(IRepositoryContext db)
        {
            _db = db;
        }

        public void AddUser(User user)
        {
            _db.User.Add(user);
        }

        public void DeleteUser(int id)
        {
            var toDelete = _db.User.Find(id);
            _db.User.Remove(toDelete);
        }

        public IQueryable<User> GetAllUsers()
        {
            return _db.User.AsNoTracking();
        }

        public User GetUserById(int id)
        {
            return _db.User.Find(id);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _db.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
