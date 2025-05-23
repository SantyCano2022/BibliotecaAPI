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
    public class DevolucionConfiguration : IEntityTypeConfiguration<Devolucion>
    {
        public void Configure(EntityTypeBuilder<Devolucion> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Devoluci_3214EC07FE5BBBCC");

            builder.ToTable("Devolucion");

            builder.HasOne(d => d.Prestamo).WithMany()
                .HasForeignKey(d => d.PrestamoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DevolucioPrest_398D8EEE");
        }

        
    }
}
