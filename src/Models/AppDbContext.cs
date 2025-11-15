using Microsoft.EntityFrameworkCore;
using SaberMais.Models;

namespace SaberMais.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Administrador> Administradores { get; set; }

        // Configurações do modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ===================================================
            // CONFIGURAÇÃO DA ENTIDADE CURSO
            // ===================================================

            modelBuilder.Entity<Curso>(entity =>
            {
                // Definir precisão decimal (corrige o aviso)
                entity.Property(c => c.Valor)
                    .HasPrecision(18, 2);

                // Definir comprimentos máximos para otimização
                entity.Property(c => c.Titulo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(c => c.Descricao)
                    .HasMaxLength(2000);

                entity.Property(c => c.Cep)
                    .HasMaxLength(10);

                entity.Property(c => c.Logradouro)
                    .HasMaxLength(200);

                entity.Property(c => c.Bairro)
                    .HasMaxLength(100);

                entity.Property(c => c.Uf)
                    .HasMaxLength(2);
            });

            // ===================================================
            // CONFIGURAÇÃO DA ENTIDADE USUARIO
            // ===================================================

            modelBuilder.Entity<Usuario>(entity =>
            {
                // Índice único para Email (evita duplicados)
                entity.HasIndex(u => u.Email)
                    .IsUnique();

                // Índice único para Documento (evita CPF/CNPJ duplicados)
                entity.HasIndex(u => u.Documento)
                    .IsUnique();

                // Definir comprimentos máximos
                entity.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(u => u.NomeCompleto)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(u => u.TipoPessoa)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(u => u.Documento)
                    .IsRequired()
                    .HasMaxLength(18);
            });

            // ===================================================
            // CONFIGURAÇÃO DA ENTIDADE ADMINISTRADOR
            // ===================================================

            modelBuilder.Entity<Administrador>(entity =>
            {
                // Índice único para Email
                entity.HasIndex(a => a.Email)
                    .IsUnique();

                // Definir comprimentos máximos
                entity.Property(a => a.Nome)
                    .HasMaxLength(200);

                entity.Property(a => a.Email)
                    .HasMaxLength(255);

                entity.Property(a => a.IsSuperAdmin)
                    .HasDefaultValue(false);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
