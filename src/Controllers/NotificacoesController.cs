using Microsoft.AspNetCore.Mvc;
using SaberMais.Services;

namespace SaberMais.Controllers
{
    public class NotificacoesController : Controller
    {
        private readonly INotificacaoService _notificacaoService;

        public NotificacoesController(INotificacaoService notificacaoService)
        {
            _notificacaoService = notificacaoService;
        }

        [HttpPost]
        public IActionResult MarcarLida(int id)
        {
            _notificacaoService.MarcarComoLida(id);

            // Pega a URL da página anterior e redireciona de voltaa 
            string returnUrl = Request.Headers["Referer"].ToString();
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }

            // Se não conseguir detectar a página anterior, vai para Home
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult MarcarTodasLidas()
        {
            _notificacaoService.MarcarTodasComoLidas();

            // Pega a URL da página anterior e redireciona de volta
            string returnUrl = Request.Headers["Referer"].ToString();
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }

            // Se não conseguir detectar a página anterior, vai para Home
            return RedirectToAction("Index", "Home");
        }
    }
}