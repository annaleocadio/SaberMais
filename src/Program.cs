using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SaberMais.Data;
using SaberMais.Models;

namespace SaberMais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adiciona suporte a Controllers e Views
            builder.Services.AddControllersWithViews();

            // Habilita recarregamento automático das Views
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            // Configura a conexão com o banco de dados LOCAL (SQL Server LocalDB)
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Ativa e configura o sistema de autenticação via cookies
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Usuario/Login";
                    options.LogoutPath = "/Usuario/Logout";
                });

            var app = builder.Build();

            // Criar Admin padrão automaticamente
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                // Cria o banco, se não existir
                context.Database.EnsureCreated();

                // Verifica se já existe um admin
                if (!context.Administradores.Any())
                {
                    context.Administradores.Add(new Administrador
                    {
                        Nome = "Administrador Geral",
                        Email = "leocadio@sabermais.com",
                        Senha = "leocadio",
                        IsSuperAdmin = true
                    });
                    context.SaveChanges();
                }
            }

            // Configuração do pipeline de requisição
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // IMPORTANTE: UseDefaultFiles ANTES de UseStaticFiles
            app.UseDefaultFiles(new DefaultFilesOptions
            {
                DefaultFileNames = new List<string> { "index.html" }
            });

            app.UseStaticFiles(); // Serve arquivos estáticos da pasta wwwroot

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            // Define a rota padrão do sistema
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}