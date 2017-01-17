using Expenses.Domain.Models;

namespace Expenses.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Expenses.Repository.RepositoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Expenses.Repository.RepositoryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private void SeedUsers(RepositoryContext context)
        {

            var newUser = new User() { Name = "Rafa³", Surname = "Chodzid³o", Age = 25, Login = "raflotraflo", Password = "test"};
            context.Set<User>().AddOrUpdate(newUser);


            context.SaveChanges();
        }
    }
}
