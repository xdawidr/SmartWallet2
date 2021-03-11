using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class IncomeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(180);
            builder.Property(p => p.Amount).HasColumnType("decimal(18,2)");
            builder.HasOne(t => t.IncomeType).WithMany()
                .HasForeignKey(p => p.IncomeTypeId);
            builder.Property(p => p.CreatedOn).IsRequired().HasColumnType("Date");
        }
    }
}