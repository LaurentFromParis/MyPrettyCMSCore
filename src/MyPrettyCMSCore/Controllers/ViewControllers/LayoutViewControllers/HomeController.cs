using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InnovacallCoreFramework.MVC.Controllers;
using MyPrettyCMSCore.Models.ViewModels.LayoutViewModels;

namespace MyPrettyCMSCore.Controllers.ViewControllers.LayoutViewControllers
{
    public class HomeController : _CoreLayoutViewControllerBase<HomeLayoutViewModel>
    {
        public IActionResult Index()
        {
            StrongViewData._PageTitle = "Home";
            return View(StrongViewData);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
