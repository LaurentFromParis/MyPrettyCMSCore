using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnovacallCoreFramework.MVC.Controllers;
using MyPrettyCMSCore.Models.ViewModels.ComponentViewModels;

namespace MyPrettyCMSCore.Controllers.ViewComponents
{
    public class DynamicContentViewComponent : _CoreLayoutViewComponentBase<DynamicContentComponentViewModel>
    {
        public DynamicContentViewComponent()
        {

        }

        public IViewComponentResult Invoke(string page)
        {
            StrongViewData.Page = page;
            return View(StrongViewData);
        }
    }
}
