using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
               .ToTable("Project")
               .HasKey(p => p.ProjectId);

            builder.Property(p => p.ProjectId)
               .HasColumnName("ProjectId")
               .IsRequired()
               .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Budjet)
                .HasColumnName("Budjet")
                .IsRequired();

            builder.Property(p => p.StartedDate)
                .HasColumnName("StartedDate")
                .IsRequired()
                .HasMaxLength(7);
        }
    }
}