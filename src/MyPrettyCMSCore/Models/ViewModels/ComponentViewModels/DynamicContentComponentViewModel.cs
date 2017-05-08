using InnovacallCoreFramework.MVC.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPrettyCMSCore.Models.ViewModels.ComponentViewModels
{
    public class DynamicContentComponentViewModel : _CoreLayoutViewComponentModelBase
    {
        public DynamicContentComponentViewModel()
        {
            Tags = new Dictionary<string, TagHelper>();
        }
        public Dictionary<string, TagHelper> Tags { get; set; }
        public string Page { get; set; }
    }
}
