using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConAppMySqltoMSSQL.Models;

public partial class PocContext : DbContext
{
    public PocContext()
    {
    }

    public PocContext(DbContextOptions<PocContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=poc;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.ToTable("actor");

            entity.Property(e => e.ActorId)
                .ValueGeneratedNever()
                .HasColumnName("actor_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(500)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(500)
                .HasColumnName("last_name");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("last_update");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
