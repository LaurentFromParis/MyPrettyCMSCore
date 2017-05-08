using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPrettyCMSCore.Models.WebApiModels;
using InnovacallCoreFramework.MVC.Controllers;

namespace MyPrettyCMSCore.Controllers.WebApiControllers
{
    [Produces("application/json")]
    [Route("api/CommonSettings")]
    public class CommonSettingsController : _CoreWebApiControllerBase<CommonSettingsApiModel>
    {
        [HttpGet]
        public CommonSettingsApiModel Get()
        {
            StrongApiData._ApplicationName = "MyPrettyCMSCore";
            return StrongApiData;
        }
    }
}