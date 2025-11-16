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
        public DbSet<Avaliacao> Avaliacoes { get; set; } // ✅ NOVO
        public DbSet<Mensagem> Mensagens { get; set; }   // ✅ NOVO

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ===================================================
            // CONFIGURAÇÃO DA ENTIDADE CURSO
            // ===================================================
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(c => c.Valor).HasPrecision(18, 2);
                entity.Property(c => c.Titulo).IsRequired().HasMaxLength(200);
                entity.Property(c => c.Descricao).HasMaxLength(2000);
                entity.Property(c => c.Cep).HasMaxLength(10);
                entity.Property(c => c.Logradouro).HasMaxLength(200);
                entity.Property(c => c.Bairro).HasMaxLength(100);
                entity.Property(c => c.Uf).HasMaxLength(2);
            });

            // ===================================================
            // CONFIGURAÇÃO DA ENTIDADE USUARIO
            // ===================================================
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(u => u.Email).IsUnique();
                entity.HasIndex(u => u.Documento).IsUnique();
                entity.Property(u => u.Email).IsRequired().HasMaxLength(255);
                entity.Property(u => u.NomeCompleto).IsRequired().HasMaxLength(200);
                entity.Property(u => u.TipoPessoa).IsRequired().HasMaxLength(20);
                entity.Property(u => u.Documento).IsRequired().HasMaxLength(18);
            });

            // ===================================================
            // CONFIGURAÇÃO DA ENTIDADE ADMINISTRADOR
            // ===================================================
            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasIndex(a => a.Email).IsUnique();
                entity.Property(a => a.Nome).HasMaxLength(200);
                entity.Property(a => a.Email).HasMaxLength(255);
                entity.Property(a => a.IsSuperAdmin).HasDefaultValue(false);
            });

            // ===================================================
            // ✅ CONFIGURAÇÃO DA ENTIDADE AVALIACAO
            // ===================================================
            modelBuilder.Entity<Avaliacao>(entity =>
            {
                entity.HasOne(a => a.UsuarioAvaliador)
                    .WithMany()
                    .HasForeignKey(a => a.UsuarioAvaliadorId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(a => a.UsuarioAvaliado)
                    .WithMany()
                    .HasForeignKey(a => a.UsuarioAvaliadoId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(a => a.Comentario).HasMaxLength(1000);
            });

            // ===================================================
            // ✅ CONFIGURAÇÃO DA ENTIDADE MENSAGEM
            // ===================================================
            modelBuilder.Entity<Mensagem>(entity =>
            {
                entity.HasOne(m => m.Remetente)
                    .WithMany()
                    .HasForeignKey(m => m.RemetenteId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(m => m.Destinatario)
                    .WithMany()
                    .HasForeignKey(m => m.DestinatarioId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(m => m.Assunto).IsRequired().HasMaxLength(200);
                entity.Property(m => m.Conteudo).IsRequired().HasMaxLength(2000);
                entity.Property(m => m.Lida).HasDefaultValue(false);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}