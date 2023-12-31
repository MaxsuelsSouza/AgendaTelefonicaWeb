using AgendaTelefonica.Api.Damain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaTelefonica.Api.Data.Mappings
{
    public class ContatosMap : IEntityTypeConfiguration<Contatos>
    {
        public void Configure(EntityTypeBuilder<Contatos> builder)
        {
            builder.ToTable("contatos")
            .HasKey(p => p.Id);

            builder.HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(fk => fk.IdUsuario);

            builder.Property(p => p.Nome)
            .HasColumnType("VARCHAR")
            .IsRequired();

            builder.Property(p => p.SobreNome)
            .HasColumnType("VARCHAR");


            builder.Property(p => p.Numero)
            .HasColumnType("VARCHAR")
            .IsRequired();

            builder.Property(p => p.Email)
            .HasColumnType("VARCHAR");


            builder.Property(p => p.Endereco)
            .HasColumnType("VARCHAR");


            builder.Property(p => p.RedeSocial)
            .HasColumnType("VARCHAR");

            builder.Property(p => p.Nota)
            .HasColumnType("VARCHAR");

        }
    }
}