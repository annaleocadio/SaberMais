using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using SaberMais.Data;
using SaberMais.Services;
using System.Linq;
using System.Security.Claims;

namespace SaberMais.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotificacaoService _notificacaoService;

        public BaseController(INotificacaoService notificacaoService)
        {
            _notificacaoService = notificacaoService;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Notificações existentes
            ViewBag.Notificacoes = _notificacaoService.ObterNotificacoes();
            ViewBag.TotalNotificacoes = _notificacaoService.ContarNaoLidas();

            // ✅ NOVO: Contador de mensagens não lidas
            if (User.Identity?.IsAuthenticated == true)
            {
                var dbContext = context.HttpContext.RequestServices.GetRequiredService<AppDbContext>();
                var emailLogado = User.FindFirstValue(ClaimTypes.Email);

                if (!string.IsNullOrEmpty(emailLogado))
                {
                    var usuario = dbContext.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

                    if (usuario != null)
                    {
                        var mensagensNaoLidas = dbContext.Mensagens
                            .Count(m => m.DestinatarioId == usuario.Id && !m.Lida);

                        ViewBag.MensagensNaoLidas = mensagensNaoLidas;
                    }
                }
            }

            base.OnActionExecuting(context);
        }
    }
}