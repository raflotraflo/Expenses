using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Expenses.Domain.Models;

namespace Expenses.Repository.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Login).IsRequired().HasMaxLength(30);
            Property(t => t.Password).IsOptional();
            Property(t => t.Name).IsRequired();
            Property(t => t.Surname).IsOptional();
            Property(t => t.Age).IsOptional();
            ToTable("User");
        }
    }
}
