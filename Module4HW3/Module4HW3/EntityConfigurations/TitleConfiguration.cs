using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3
{
    internal class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
               .ToTable("Title")
               .HasKey(p => p.TitleId);

            builder.Property(p => p.TitleId)
               .HasColumnName("TitleId")
               .IsRequired()
               .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}