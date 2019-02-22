using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HepsiBurada.WEB.UI.Controllers
{
    public class PartialController : Controller
    {
        public PartialViewResult AdminFooterPartial()
        {
            return PartialView(viewName: "Partial/_AdminFooterPartial");
        }
        public PartialViewResult AdminHeaderPartial()
        {
            return PartialView(viewName: "Partial/_AdminHeaderPartial");
        }
        public PartialViewResult AdminMenuPartial()
        {
            return PartialView(viewName: "Partial/_AdminMenuPartial");
        }

    }
}