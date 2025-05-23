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
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Material_3214EC07A6DA005D");

            builder.ToTable("Material");

            builder.Property(e => e.Estado).HasDefaultValue(true);
            builder.Property(e => e.Titulo).HasMaxLength(255);
            builder.Property(e => e.NroIdentificacion).HasMaxLength(255);

            builder.HasOne(d => d.TipoMaterial).WithMany()
                .HasForeignKey(d => d.TipoMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialTipoMa_29572725");
        }
    }
}
