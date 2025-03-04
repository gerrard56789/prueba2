using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Practica20250304.AppMVCDataFirst.Models;

public partial class Practica04032025DataFirstContext : DbContext
{
    public Practica04032025DataFirstContext()
    {
    }

    public Practica04032025DataFirstContext(DbContextOptions<Practica04032025DataFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC075844A085");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
