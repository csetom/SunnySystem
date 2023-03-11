using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SunnySystem.Data.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace SunnySystem.Data;

public partial class SunnySystemDbContext : DbContext
{
    public SunnySystemDbContext()
    {
    }

    public SunnySystemDbContext(DbContextOptions<SunnySystemDbContext> options)
        : base(options)
    {
      //   this.Database.EnsureCreated();
    }

    public virtual DbSet<Component> Components { get; set; }
    public virtual DbSet<Bin> Bins { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string solutionFolder = Directory.GetParent(path: Directory.GetCurrentDirectory()).FullName;
        string dbFilePath =  Path.Combine(solutionFolder,"SunnySystem.Data","SunnySystem.db");    
        string connectionString = $"Data Source={dbFilePath}";
        optionsBuilder.UseSqlite(connectionString).LogTo(Console.WriteLine); // Ide kell majd better logging

  
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (modelBuilder is null)
        {
            throw new ArgumentNullException(nameof(modelBuilder));
        }

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

        modelBuilder.Entity<Component>(entity =>
        {
            entity.HasKey(e => e.Componentid).HasName("componentsmain_pkey");

            entity.ToTable("components");

            entity.Property(e => e.Componentid).HasColumnName("componentid");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.Max).HasColumnName("max");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Bin>(entity =>
        {
            entity.HasKey(e => e.Binid).HasName("warehouse_pkey");

            entity.ToTable("warehouse");

            entity.Property(e => e.Binid).HasColumnName("binid");
            entity.Property(e => e.Column).HasColumnName("column");
            entity.Property(e => e.Componentid).HasColumnName("componentid");
            entity.Property(e => e.Piece).HasColumnName("piece");
            entity.Property(e => e.Row).HasColumnName("row");
            entity.Property(e => e.Stash).HasColumnName("stash");

            entity.HasOne(d => d.Component).WithMany(p => p.Bins)
                .HasForeignKey(d => d.Componentid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_warehouse_componentid");
        });

        modelBuilder.Entity<Project>(entity=>{
            entity.HasOne<Customer>(p => p.Customer).WithMany(c=> c.Projects)
            .HasForeignKey(e => e.CustomerId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_project_customerid");
;
        });
        User user= new User("Admin","Admin",-1);
        modelBuilder.Entity<User>().HasData(user);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
