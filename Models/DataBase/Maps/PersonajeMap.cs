using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VisitorPatron.Models.DataBase.Maps
{
    public class PersonajeMap : IEntityTypeConfiguration<Personaje>
    {
        public void Configure(EntityTypeBuilder<Personaje> builder)
        {
            builder.ToTable("Personaje");
            builder.HasKey(o => o.IdPersonaje);
        }
    }
}