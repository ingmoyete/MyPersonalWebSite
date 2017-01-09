using PersonalWebDavid.Filters;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebDavid
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Language());
        }
    }
}
