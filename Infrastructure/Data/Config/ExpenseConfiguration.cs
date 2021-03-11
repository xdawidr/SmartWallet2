using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(180);
            builder.Property(p => p.Amount).HasColumnType("decimal(18,2)");
            builder.HasOne(t => t.ExpenseType).WithMany()
                .HasForeignKey(p => p.ExpenseTypeId);
            builder.Property(p => p.CreatedOn).IsRequired().HasColumnType("Date");
        }
    }
}