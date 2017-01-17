using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expenses.Domain.Models;

namespace Expenses.Repository
{
    public interface IRepositoryContext
    {
        //DbSet<Availability> Availability { get; set; }
        //DbSet<CVApplication> CVApplication { get; set; }
        //DbSet<CVFile> CVFile { get; set; }
        //DbSet<Place> Place { get; set; }
        DbSet<User> User { get; set; }

        int SaveChanges();
        DbEntityEntry Entry(object entity);

        Database Database { get; }
    }
}
