using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _TestemonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
