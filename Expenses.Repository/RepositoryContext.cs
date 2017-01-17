using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Expenses.Domain.Models;
using System;

namespace Expenses.Repository
{
    public class RepositoryContext : DbContext, IRepositoryContext
    {
        #region Ctor

        public RepositoryContext() { }

        public RepositoryContext(string connectionString): base(connectionString) { }

        #endregion

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Potrzebne dla klas Identity
            //base.OnModelCreating(modelBuilder);

            // using System.Data.Entity.ModelConfiguration.Conventions;
            //Wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            // Zamiast Kategorie zostałaby stworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Wyłącza konwencję CascadeDelete
            // CascadeDelete zostanie włączone za pomocą Fluent API
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Używa się Fluent API, aby ustalić powiązanie pomiędzy tabelami 
            // i włączyć CascadeDelete dla tego powiązania
            //modelBuilder.Entity<Ogloszenie>().HasRequired(x => x.Uzytkownik)
            //    .WithMany(x => x.Ogloszenia)
            //    .HasForeignKey(x => x.UzytkownikId)
            //    .WillCascadeOnDelete(true);

            //modelBuilder.Entity<CVApplication>().Ignore(e => e.CVFile);
        }
    }

}
