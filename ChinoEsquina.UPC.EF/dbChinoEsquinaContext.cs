using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChinoEsquina.UPC.EF
{
    public partial class dbChinoEsquinaContext : DbContext
    {
        public dbChinoEsquinaContext()
        {
        }

        public dbChinoEsquinaContext(DbContextOptions<dbChinoEsquinaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Compra> Compras { get; set; } = null!;
        public virtual DbSet<CompraDetalle> CompraDetalles { get; set; } = null!;
        public virtual DbSet<CompraPromocion> CompraPromocions { get; set; } = null!;
        public virtual DbSet<DocumentoIdentidad> DocumentoIdentidads { get; set; } = null!;
        public virtual DbSet<Promocion> Promocions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-87DC60U\\SQLEXPRESS; Database=dbChinoEsquina; User=sa; Password=password");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FechaModifico)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modifico");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro");

                entity.Property(e => e.IdDocumentoIdentidad).HasColumnName("id_documento_identidad");

                entity.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");

                entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nro_documento");

                entity.HasOne(d => d.IdDocumentoIdentidadNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdDocumentoIdentidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente_documento_identidad");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra);

                entity.ToTable("compra");

                entity.Property(e => e.IdCompra).HasColumnName("id_compra");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaModifico)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modifico");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");

                entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");

                entity.Property(e => e.MontoVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto_venta");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_venta");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_compra_cliente");
            });

            modelBuilder.Entity<CompraDetalle>(entity =>
            {
                entity.HasKey(e => e.IdCompraDetalle);

                entity.ToTable("compra_detalle");

                entity.Property(e => e.IdCompraDetalle).HasColumnName("id_compra_detalle");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.FechaModifico)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modifico");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro");

                entity.Property(e => e.IdCompra).HasColumnName("id_compra");

                entity.Property(e => e.IdProductoVenta).HasColumnName("id_producto_venta");

                entity.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");

                entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_venta");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.CompraDetalles)
                    .HasForeignKey(d => d.IdCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_compra_detalle_compra");
            });

            modelBuilder.Entity<CompraPromocion>(entity =>
            {
                entity.HasKey(e => new { e.IdCompra, e.IdPromocion });

                entity.ToTable("compra_promocion");

                entity.Property(e => e.IdCompra).HasColumnName("id_compra");

                entity.Property(e => e.IdPromocion).HasColumnName("id_promocion");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.FechaModifico)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modifico");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro");

                entity.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");

                entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");

                entity.Property(e => e.Puntos).HasColumnName("puntos");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.CompraPromocions)
                    .HasForeignKey(d => d.IdCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_compra_promocion_compra");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.CompraPromocions)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_compra_promocion_promocion");
            });

            modelBuilder.Entity<DocumentoIdentidad>(entity =>
            {
                entity.HasKey(e => e.IdDocumentoIdentidad);

                entity.ToTable("documento_identidad");

                entity.Property(e => e.IdDocumentoIdentidad).HasColumnName("id_documento_identidad");

                entity.Property(e => e.Abreviatura)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("abreviatura");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.FechaModifico)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modifico");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro");

                entity.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");

                entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Promocion>(entity =>
            {
                entity.HasKey(e => e.IdPromocion);

                entity.ToTable("promocion");

                entity.Property(e => e.IdPromocion).HasColumnName("id_promocion");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.FechaFinal)
                    .HasColumnType("date")
                    .HasColumnName("fecha_final");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.FechaModifico)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modifico");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro");

                entity.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");

                entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
