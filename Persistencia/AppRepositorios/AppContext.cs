using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AppContext:DbContext
    {
        //Atributos
        public DbSet<Deportista> Deportistas {get;set;}
        public DbSet<Entrenador> Entrenadores {get;set;}
        public DbSet<Equipo> Equipos {get;set;}
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Patrocinador> Patrocinadores {get;set;}
        public DbSet<Torneo> Torneos {get;set;}
        public DbSet<TorneoEquipo> TorneoEquipos {get;set;}
        public DbSet<Arbitro> Arbitros {get;set;}
        public DbSet<Escenario> Escenarios {get;set;}
        public DbSet<Cancha> Canchas {get;set;}
        public DbSet<EscuelaArbitro> EscuelaArbitros {get;set;}

        //Metodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                // Generamos la BD automáticamente en base a todo lo que los DbSet configuran
                // y en base a lo que  se encuentre en Dominio
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EventosDep");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Esto permite que el programa pueda tomar como llaves primarias las ID mencionadas
            // Por ser una tabla compuesta que no tiene llave primaria propia hay que hacer este método
            // Todo haciendo esto para definir carga compuesta
            modelBuilder.Entity<TorneoEquipo>().HasKey(x=> new{x.EquipoId,x.TorneoId});
        }

    }
}