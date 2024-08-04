using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutDescription = context.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.aboutDetails = context.Abouts.Select(x => x.AboutDetails).FirstOrDefault();
            
            return View();
        }
    }
}
