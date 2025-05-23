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
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Rol_3214EC078546CF55");

            builder.ToTable("Rol");

            builder.HasIndex(e => e.Nombre, "UQ_Rol_75E3EFCFED34561F").IsUnique();

            builder.Property(e => e.Estado).HasDefaultValue(true);
            builder.Property(e => e.Nombre).HasMaxLength(50);
        }
    }
}
