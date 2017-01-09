using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PersonalWebDavid.FiltersAndClases
{
    public class DomainRouteData : RouteBase
    {
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            return null;
        }
        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            return null;
        }
    }
}