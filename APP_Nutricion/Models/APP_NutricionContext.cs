using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APP_Nutricion.Models
{
    public partial class APP_NutricionContext : DbContext
    {
        public APP_NutricionContext()
        {
        }

        public APP_NutricionContext(DbContextOptions<APP_NutricionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alimento> Alimentos { get; set; } = null!;
        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Cena> Cenas { get; set; } = null!;
        public virtual DbSet<Colacion> Colacions { get; set; } = null!;
        public virtual DbSet<Comida> Comida { get; set; } = null!;
        public virtual DbSet<Desayuno> Desayunos { get; set; } = null!;
        public virtual DbSet<InfoUsario> InfoUsarios { get; set; } = null!;
        public virtual DbSet<Unidad> Unidads { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConexionApp");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alimento>(entity =>
            {
                entity.HasKey(e => e.IdAlimento)
                    .HasName("PK__Alimento__24065705BBC2956F");

                entity.Property(e => e.Calorias).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Carbohidratos).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Fibra).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Grasas).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.NombreAlimento)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.Proteinas).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Sodio).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Alimentos)
                    .HasForeignKey(d => d.CategoriaId)
                    .HasConstraintName("FK__Alimentos__Categ__5441852A");

                entity.HasOne(d => d.Unidad)
                    .WithMany(p => p.Alimentos)
                    .HasForeignKey(d => d.UnidadId)
                    .HasConstraintName("FK__Alimentos__Unida__5535A963");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A104EF379B2");

                entity.Property(e => e.NombreCategoria)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cena>(entity =>
            {
                entity.HasKey(e => e.IdCena)
                    .HasName("PK__Cena__3A4B0304A7633DFB");

                entity.ToTable("Cena");

                entity.HasOne(d => d.Alimento)
                    .WithMany(p => p.Cenas)
                    .HasForeignKey(d => d.AlimentoId)
                    .HasConstraintName("FK__Cena__AlimentoId__66603565");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Cenas)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__Cena__UsuarioId__6754599E");
            });

            modelBuilder.Entity<Colacion>(entity =>
            {
                entity.HasKey(e => e.IdColacion)
                    .HasName("PK__Colacion__88E772FF6CD1AAC0");

                entity.ToTable("Colacion");

                entity.HasOne(d => d.Alimento)
                    .WithMany(p => p.Colacions)
                    .HasForeignKey(d => d.AlimentoId)
                    .HasConstraintName("FK__Colacion__Alimen__6A30C649");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Colacions)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__Colacion__Usuari__6B24EA82");
            });

            modelBuilder.Entity<Comida>(entity =>
            {
                entity.HasKey(e => e.IdComida)
                    .HasName("PK__Comida__055A1AA30FEE9343");

                entity.HasOne(d => d.Alimento)
                    .WithMany(p => p.Comida)
                    .HasForeignKey(d => d.AlimentoId)
                    .HasConstraintName("FK__Comida__Alimento__628FA481");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Comida)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__Comida__UsuarioI__6383C8BA");
            });

            modelBuilder.Entity<Desayuno>(entity =>
            {
                entity.HasKey(e => e.IdDesayuno)
                    .HasName("PK__Desayuno__DF8980C8981A94CD");

                entity.ToTable("Desayuno");

                entity.HasOne(d => d.Alimento)
                    .WithMany(p => p.Desayunos)
                    .HasForeignKey(d => d.AlimentoId)
                    .HasConstraintName("FK__Desayuno__Alimen__5EBF139D");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Desayunos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__Desayuno__Usuari__5FB337D6");
            });

            modelBuilder.Entity<InfoUsario>(entity =>
            {
                entity.HasKey(e => e.IdInfo)
                    .HasName("PK__InfoUsar__50705EB45815487F");

                entity.ToTable("InfoUsario");

                entity.Property(e => e.NivelActividad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReqCaloricos).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.InfoUsarios)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__InfoUsari__Usuar__5BE2A6F2");
            });

            modelBuilder.Entity<Unidad>(entity =>
            {
                entity.HasKey(e => e.IdUnidad)
                    .HasName("PK__Unidad__437725E647F1EED5");

                entity.ToTable("Unidad");

                entity.Property(e => e.NombreUnidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF97762E1AF8");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Materno)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Paterno)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
