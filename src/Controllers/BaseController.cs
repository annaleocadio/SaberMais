using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SaberMais.Services;

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
            ViewBag.Notificacoes = _notificacaoService.ObterNotificacoes();
            ViewBag.TotalNotificacoes = _notificacaoService.ContarNaoLidas();
            base.OnActionExecuting(context);
        }
    }
}