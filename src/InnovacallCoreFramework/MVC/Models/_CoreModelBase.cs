using System;
using System.Collections.Generic;
using System.Text;

namespace InnovacallCoreFramework.MVC.Models
{
    public class _CoreModelBase
    {
        public _CoreModelBase()
        {
            Error = new _CoreCommonErrorModel();
        }
        public _CoreCommonErrorModel Error { get; set; }
    }
}
