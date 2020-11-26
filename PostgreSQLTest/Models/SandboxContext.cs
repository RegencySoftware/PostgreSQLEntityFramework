using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PostgreSQLTest.Models
{
    public partial class SandboxContext : DbContext
    {
        //If you regenerate this class the connection string property needs to be added back
        //and referenced in OnConfiguring
        public string cnnString { get; set; }
        public SandboxContext()
        {
        }

        public SandboxContext(DbContextOptions<SandboxContext> options)
            : base(options)
        {

        }

        public virtual DbSet<QuoteData> QuoteData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(cnnString, x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuoteData>(entity =>
            {
                entity.ToTable( "quote_data", "crypto_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Symbol)
                    .HasMaxLength(128)
                    .HasColumnName("symbol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
