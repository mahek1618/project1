using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CricketWebApp.Models
{
    public partial class CricketContext : DbContext
    {
        public CricketContext()
        {
        }

        public CricketContext(DbContextOptions<CricketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Stadium> State { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Cricket;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.HasIndex(e => e.CountryCode)
                    .HasName("UQ__country__5D9B0D2C538C4FAD")
                    .IsUnique();

                entity.Property(e => e.Continent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matches>(entity =>
            {
                entity.HasKey(e => e.MatchId);

                entity.Property(e => e.DateTime)
                    .HasColumnName("Date_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('null')");

                entity.Property(e => e.TeamA)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamB)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WasMatchPlayed).HasColumnName("Was_match_played");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("player");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlayerCo)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.PlayerCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_player_country");
            });

            modelBuilder.Entity<Stadium>(entity =>
            {
                entity.ToTable("state");

                entity.Property(e => e.NoOfMatchesAllowed).HasColumnName("No_of_matches_allowed");

                entity.Property(e => e.Statecountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.StateCo)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.StateCoId)
                    .HasConstraintName("FK_state_country");
            });
        }
    }
}
