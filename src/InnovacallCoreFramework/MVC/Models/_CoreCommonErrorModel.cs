using System;
using System.Collections.Generic;
using System.Text;

namespace InnovacallCoreFramework.MVC.Models
{
    public class _CoreCommonErrorModel : Exception
    {
        public string FriendlyMessage { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
    }
}
