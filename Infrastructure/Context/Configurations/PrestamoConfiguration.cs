using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Configurations
{
    public class PrestamoConfiguration : IEntityTypeConfiguration<Prestamo>
    {
        public void Configure(EntityTypeBuilder<Prestamo> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Prestamo_3214EC076AF2F0AC");

            builder.ToTable("Prestamo");

            builder.Property(e => e.Estado).HasDefaultValue(true);

            builder.HasOne(d => d.Material).WithMany()
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestamoMateri_36B12243");

            builder.HasOne(d => d.Usuario).WithMany()
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestamoUsuari_35BCFE0A");
        }
    }
}
