using System;
using System.Linq;
using ExameBE.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace ExameBE.Infrastructure.Context
{
    public class MainContext : DbContext
    {
        #region Properties
        public DbSet<Anuncio> Ads { get; set; }
        #endregion

        #region Constructors
        public MainContext(): base()
        {
        }
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anuncio>()
                .HasData(
                new Anuncio
                {
                    Id = 1,
                    Subject = "T2, Vila Nova de Gaia, 2014, 250000€",
                    Description = "Com garagem. Acessos. Escolas. Metro.",
                    Contact = "93XXXXXXX",
                    AdType = Anuncio.AdTypes.Imóvel
                },
                new Anuncio
                {
                    Id = 2,
                    Subject = "Zome, Porto, Consultor, Júnior, Full-time",
                    Description = "Salário: 1500-2000€ mensais. Entrada imediata. Missões: - Avaliação Imobiliária! - Mediação e Angariação Imobiliária! - Apoio á construção, obras, remodelações e Projetos Arquitetura!",
                    Contact = "93XXXXXXX",
                    AdType = Anuncio.AdTypes.Emprego
                },
                new Anuncio
                {
                    Id = 3,
                    Subject = "Mazda CX-5, Loulé, 2018, 40000 Km, 27000€",
                    Description = "Revisão feita sempre na marca. Como novo.",
                    Contact = "xxx@yx.com",
                    AdType = Anuncio.AdTypes.Automóvel
                }
                );
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is Anuncio && e.State == EntityState.Added);

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                    ((Anuncio)entry.Entity).CreationDate = DateTime.Now;
            }
            return base.SaveChanges();
        }
        #endregion

    }
}
