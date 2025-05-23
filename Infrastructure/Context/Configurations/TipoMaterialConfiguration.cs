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
    public class TipoMaterialConfiguration : IEntityTypeConfiguration<TipoMaterial>
    {
        public void Configure(EntityTypeBuilder<TipoMaterial> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_TipoMate_3214EC074ACB285B");

            builder.ToTable("TipoMaterial");

            builder.HasIndex(e => e.Nombre, "UQ_TipoMate_75E3EFCF91A9CAE8").IsUnique();

            builder.Property(e => e.Estado).HasDefaultValue(true);
            builder.Property(e => e.Nombre).HasMaxLength(100);
        }
    }
}
