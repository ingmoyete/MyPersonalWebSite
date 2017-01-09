using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebDavid.Filters
{
    public class Language: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string language = (string)filterContext.RouteData.Values["language"] ?? "en";
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);

        }
    }
}