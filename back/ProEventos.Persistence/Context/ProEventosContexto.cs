using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;

namespace ProEventos.Persistence.Context
{
    public class ProEventosContexto: DbContext
    {
        public ProEventosContexto(DbContextOptions<ProEventosContexto> options): base(options){    }
        public DbSet<Evento> Eventos { get; set;}
        public DbSet<Lote> Lotes { get; set;}
        public DbSet<RedeSocial> RedesSociais { get; set;}
        public DbSet<Palestrante> Palestrantes { get; set;}
        public DbSet<EventoPalestrante> EventosPalestrantes { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventoPalestrante>().HasKey(EP => new { EP.EventoId, EP.PalestranteId});
        }
    }
}