using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3
{
    internal class EmployeeProjectConfguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
               .ToTable("EmployeeProject")
               .HasKey(p => p.EmployeeProjectId);

            builder.Property(p => p.EmployeeProjectId)
               .HasColumnName("EmployeeProjectId")
               .IsRequired()
               .ValueGeneratedOnAdd();

            builder.Property(p => p.Rate)
                .HasColumnName("Rate")
                .IsRequired();

            builder.Property(p => p.StartedDate)
                .HasColumnName("StartedDate")
                .IsRequired()
                .HasMaxLength(7);
        }
    }
}