using GICM.Domain.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GICM.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(d => d.Id).IsRequired();
            builder.Property(d => d.Nome).HasMaxLength(200).IsRequired();
            builder.Property(d => d.Email).HasMaxLength(200).IsRequired();
        }
    }
}