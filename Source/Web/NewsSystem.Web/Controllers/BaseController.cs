using NewsSystem.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsSystem.Web.Controllers
{
    public class BaseController : Controller
    {
        protected NewsSystemData Data { get; private set; }

        public BaseController(NewsSystemData data )
        {
            this.Data = data;
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
        }
    }
}