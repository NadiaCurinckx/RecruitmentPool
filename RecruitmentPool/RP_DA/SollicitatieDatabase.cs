using RP_Model;
using System;
using System.Data.Entity;

namespace RP_DA
{
    public class SollicitatieDatabase : DbContext, ISollicitatieDatabase
    {
        private static readonly String _connectionString = "Config";

        public DbSet<Persoon> Personen { get; set; }
        public DbSet<Sollicitatie> Sollicitaties { get; set; }

        public SollicitatieDatabase() : base(_connectionString)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persoon>().ToTable("Persoon");
            modelBuilder.Entity<Persoon>().HasKey(p => p.IdPersoon);
            modelBuilder.Entity<Sollicitatie>().ToTable("Sollicitatie");
            modelBuilder.Entity<Sollicitatie>().HasKey(s => s.IdSollicitatie);
            base.OnModelCreating(modelBuilder);
        }
    }
}
