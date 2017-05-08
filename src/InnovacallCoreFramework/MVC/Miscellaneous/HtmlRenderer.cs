using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;

namespace InnovacallCoreFramework.MVC.Miscellaneous
{
    public class HtmlRenderer : RazorViewEngine
    {
        public HtmlRenderer(IRazorPageFactoryProvider pageFactory, IRazorPageActivator pageActivator, HtmlEncoder htmlEncoder, IOptions<RazorViewEngineOptions> optionsAccessor, ILoggerFactory loggerFactory) : base(pageFactory, pageActivator, htmlEncoder, optionsAccessor, loggerFactory)
        {
        }
    }
}
