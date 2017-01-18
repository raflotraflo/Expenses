using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Expenses.Domain.Models;


namespace Expenses.Repository.Map
{
    public class ShoppingMap : EntityTypeConfiguration<Shopping>
    {
        public ShoppingMap()
        {
            ToTable("Shopping");

            HasKey(t => t.Id);
            Property(t => t.UserId).IsRequired();
            Property(t => t.CategoryId).IsRequired();
            Property(t => t.Name).IsRequired();
            Property(t => t.Timestamp).IsOptional();
            Property(t => t.Cost).IsRequired();

            HasRequired(p => p.User).WithMany().HasForeignKey(x => x.UserId).WillCascadeOnDelete(true);
            HasRequired(p => p.Category).WithMany().HasForeignKey(x => x.CategoryId).WillCascadeOnDelete(true);
        }
    }
}
