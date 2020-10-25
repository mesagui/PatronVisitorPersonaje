using Microsoft.EntityFrameworkCore;
using VisitorPatron.Models.DataBase.Maps;

namespace VisitorPatron.Models.DataBase
{

   

    public class PersonajeContext:DbContext
    {

        public PersonajeContext(DbContextOptions<PersonajeContext> options):base(options)
        {
            
        }
        public DbSet<Personaje> Personajes {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonajeMap());
        }
    }
}