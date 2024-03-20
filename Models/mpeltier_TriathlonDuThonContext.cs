using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Triathlon.Models
{
    public partial class mpeltier_TriathlonDuThonContext : DbContext
    {
        public mpeltier_TriathlonDuThonContext()
        {
        }

        public mpeltier_TriathlonDuThonContext(DbContextOptions<mpeltier_TriathlonDuThonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assurance> Assurances { get; set; } = null!;
        public virtual DbSet<Categorie> Categories { get; set; } = null!;
        public virtual DbSet<Club> Clubs { get; set; } = null!;
        public virtual DbSet<Inscription> Inscriptions { get; set; } = null!;
        public virtual DbSet<Licence> Licences { get; set; } = null!;
        public virtual DbSet<Triathlon> Triathlons { get; set; } = null!;
        public virtual DbSet<TypeTriathlon> TypeTriathlons { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.4.1;port=3306;user=sqlmpeltier;password=savary;database=mpeltier_TriathlonDuThon;sslmode=required;charset=utf8", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.6-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Assurance>(entity =>
            {
                entity.HasKey(e => e.AssuId)
                    .HasName("PRIMARY");

                entity.Property(e => e.AssuNom).IsFixedLength();
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.Property(e => e.ClubCp).IsFixedLength();

                entity.Property(e => e.ClubTel).IsFixedLength();
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => new { e.TriId, e.InscDossard })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasOne(d => d.Lic)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.LicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPTION_LICENCE");

                entity.HasOne(d => d.Tri)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.TriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPTION_TRIATHLON");
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.HasKey(e => e.LicId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LicCodePostal).IsFixedLength();

                entity.Property(e => e.LicNumAssure).IsFixedLength();

                entity.HasOne(d => d.Assu)
                    .WithMany(p => p.Licences)
                    .HasForeignKey(d => d.AssuId)
                    .HasConstraintName("FK_LICENCE_ASSURANCE");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Licences)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK_LICENCE_CATEGORIE");

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.Licences)
                    .HasForeignKey(d => d.ClubId)
                    .HasConstraintName("FK_LICENCE_CLUB");
            });

            modelBuilder.Entity<Triathlon>(entity =>
            {
                entity.HasKey(e => e.TriId)
                    .HasName("PRIMARY");

                entity.Property(e => e.TriCp).IsFixedLength();

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Triathlons)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRIATHLON_TYPE_TRIATHLON");
            });

            modelBuilder.Entity<TypeTriathlon>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PRIMARY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
