using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3
{
    internal class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
               .ToTable("Office")
               .HasKey(p => p.OfficeId);

            builder.Property(p => p.OfficeId)
               .HasColumnName("EmployeeProjectId")
               .IsRequired()
               .ValueGeneratedOnAdd();

            builder.Property(p => p.Title)
                .HasColumnName("Rate")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Location)
                .HasColumnName("StartedDate")
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}