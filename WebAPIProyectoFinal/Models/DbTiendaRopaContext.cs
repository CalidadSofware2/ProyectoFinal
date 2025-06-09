using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPIProyectoFinal.Models;

public partial class DbTiendaRopaContext : DbContext
{
    public DbTiendaRopaContext()
    {
    }

    public DbTiendaRopaContext(DbContextOptions<DbTiendaRopaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<InventarioDetalle> InventarioDetalles { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.IdInventario).HasName("PK__Inventar__A9DB439C7EC4D758");

            entity.ToTable("Inventario");

            entity.Property(e => e.IdInventario).HasColumnName("Id_Inventario");
        });

        modelBuilder.Entity<InventarioDetalle>(entity =>
        {
            entity.HasKey(e => new { e.ProductoidProducto, e.InventarioidInventario });

            entity.ToTable("Inventario_Detalle");

            entity.Property(e => e.ProductoidProducto).HasColumnName("Productoid_Producto");
            entity.Property(e => e.InventarioidInventario).HasColumnName("Inventarioid_Inventario");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)").HasColumnName("Total");
            entity.Property(e => e.Cantidad).HasColumnName("Cantidad");

            //entity.HasOne(d => d.InventarioidInventarioNavigation).WithMany(p => p.InventarioDetalles)
            //    .HasForeignKey(d => d.InventarioidInventario)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_InvDet_Inventario");

            //entity.HasOne(d => d.ProductoidProductoNavigation).WithMany(p => p.InventarioDetalles)
            //    .HasForeignKey(d => d.ProductoidProducto)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_InvDet_Producto");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__9B4120E207803B96");

            entity.ToTable("Producto");

            entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");
            entity.Property(e => e.CantidadStock).HasColumnName("Cantidad_Stock");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
