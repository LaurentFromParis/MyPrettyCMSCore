using InnovacallCoreFramework.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnovacallCoreFramework.MVC.Controllers
{
    public class _CoreLayoutViewComponentBase<T> : ViewComponent where T : _CoreLayoutViewComponentModelBase
    {
        #region  Variables membres
        /// <summary>
        /// The _content data
        /// </summary>
        private T _strongViewData;
        #endregion

        /// <summary>
        /// Gets or sets the content data.
        /// </summary>
        /// <value>The content data.</value>
        /// <remarks></remarks>
        public T StrongViewData
        {
            get
            {
                return _strongViewData;
            }
            set
            {
                _strongViewData = value;
            }
        }

        public _CoreLayoutViewComponentBase()
        {
            this.StrongViewData = Activator.CreateInstance<T>();
        }
    }
}
