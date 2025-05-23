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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Usuario_3214EC071F583127");

            builder.ToTable("Usuario");

            builder.HasIndex(e => e.Cedula, "UQ_Usuario_B4ADFE3858EE7959").IsUnique();

            builder.Property(e => e.Cedula).HasMaxLength(50);
            builder.Property(e => e.Estado).HasDefaultValue(true);
            builder.Property(e => e.Nombre).HasMaxLength(255);

            builder.HasOne(d => d.Rol).WithMany()
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioRolId_31EC6D26");
        }
    }
}
