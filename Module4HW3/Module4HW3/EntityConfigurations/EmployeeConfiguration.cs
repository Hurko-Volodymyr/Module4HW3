using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Module4HW3
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
               .ToTable("Employee")
               .HasKey(p => p.EmployeeId);

            builder.Property(p => p.EmployeeId)
               .HasColumnName("EmployeeId")
               .IsRequired()
               .ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName)
               .HasColumnName("EmployeeId")
               .IsRequired()
               .ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.LastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.HiredDate)
                .HasColumnName("HiredDate")
                .HasMaxLength(7);

            // builder.HasOne(h => h.Office)
            //    .WithMany(w => w.Employees)
            //    .HasForeignKey(h => h.OfficeId)
            //    .OnDelete(DeleteBehavior.Cascade);

            // builder.HasOne(h => h.Title)
            //    .WithMany(w => w.Employees)
            //    .HasForeignKey(h => h.TitleId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}