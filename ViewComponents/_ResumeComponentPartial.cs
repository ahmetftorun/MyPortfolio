﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _ResumeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
