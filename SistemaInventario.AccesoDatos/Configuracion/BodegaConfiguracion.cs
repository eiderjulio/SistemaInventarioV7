using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Configuracion
{
    public class BodegaConfiguracion : IEntityTypeConfiguration<Bodega>
    {
        public void Configure(EntityTypeBuilder<Bodega> Builder)
        {
            Builder.Property(x => x.Id).IsRequired();
            Builder.Property(x => x.Nombre).IsRequired().HasMaxLength(60);
            Builder.Property(x => x.Descripcion).IsRequired().HasMaxLength(100);
            Builder.Property(x => x.Estado).IsRequired();

        }

    }
}
