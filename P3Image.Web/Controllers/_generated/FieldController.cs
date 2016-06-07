using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P3Image.Web.Controllers
{
    public partial class FieldController : Controller
    {
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Edit()
        {
            return PartialView();
        }

	}
}
