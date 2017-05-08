using InnovacallCoreFramework.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnovacallCoreFramework.MVC.Controllers
{
    public class _CoreWebApiControllerBase<T> : Controller where T : _CoreApiModelBase
    {
        #region  Variables membres
        /// <summary>
        /// The _content data
        /// </summary>
        private T _strongApiData;
        #endregion

        public T StrongApiData
        {
            get
            {
                return _strongApiData;
            }
            set
            {
                _strongApiData = value;
            }
        }
        public _CoreWebApiControllerBase()
        {
            this.StrongApiData = Activator.CreateInstance<T>();
        }

    }
}
