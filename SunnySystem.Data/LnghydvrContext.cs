using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SunnySystem.Data.Models;

namespace SunnySystem.Data;

public partial class LnghydvrContext : DbContext
{
    public LnghydvrContext()
    {
    }

    public LnghydvrContext(DbContextOptions<LnghydvrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Componentsmain> Componentsmains { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=dumbo.db.elephantsql.com;Database=lnghydvr;User Id=lnghydvr;Password=62M5jDVpzFHriCJFUSH57p46JD3eWj9R;Port=5432");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("pg_catalog", "plv8")
            .HasPostgresExtension("btree_gin")
            .HasPostgresExtension("btree_gist")
            .HasPostgresExtension("citext")
            .HasPostgresExtension("cube")
            .HasPostgresExtension("dblink")
            .HasPostgresExtension("dict_int")
            .HasPostgresExtension("dict_xsyn")
            .HasPostgresExtension("earthdistance")
            .HasPostgresExtension("fuzzystrmatch")
            .HasPostgresExtension("hstore")
            .HasPostgresExtension("intarray")
            .HasPostgresExtension("ltree")
            .HasPostgresExtension("pg_stat_statements")
            .HasPostgresExtension("pg_trgm")
            .HasPostgresExtension("pgcrypto")
            .HasPostgresExtension("pgrowlocks")
            .HasPostgresExtension("pgstattuple")
            .HasPostgresExtension("tablefunc")
            .HasPostgresExtension("unaccent")
            .HasPostgresExtension("uuid-ossp")
            .HasPostgresExtension("xml2");

        modelBuilder.Entity<Componentsmain>(entity =>
        {
            entity.HasKey(e => e.Componentid).HasName("componentsmain_pkey");

            entity.ToTable("componentsmain");

            entity.Property(e => e.Componentid).HasColumnName("componentid");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.Max).HasColumnName("max");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.Binid).HasName("warehouse_pkey");

            entity.ToTable("warehouse");

            entity.Property(e => e.Binid).HasColumnName("binid");
            entity.Property(e => e.Column).HasColumnName("column");
            entity.Property(e => e.Componentid).HasColumnName("componentid");
            entity.Property(e => e.Piece).HasColumnName("piece");
            entity.Property(e => e.Row).HasColumnName("row");
            entity.Property(e => e.Stash).HasColumnName("stash");

            entity.HasOne(d => d.Component).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.Componentid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_warehouse_componentid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
