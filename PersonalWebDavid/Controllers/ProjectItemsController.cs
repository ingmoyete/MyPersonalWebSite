using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebDavid.Controllers
{
    public class ProjectItemsController : Controller
    {
        public ActionResult supeco()
        {
            return View("supeco");
        }

        public ActionResult abengoa()
        {
            return View("abengoa");
        }

        public ActionResult mercedes()
        {
            return View("mercedes");
        }

        public ActionResult sabic()
        {
            return View("sabic");
        }

        public ActionResult jmhermanos()
        {
            return View("jmhermanos");
        }

        public ActionResult avaLibrary()
        {
            return View("avaLibrary");
        }

    }
}