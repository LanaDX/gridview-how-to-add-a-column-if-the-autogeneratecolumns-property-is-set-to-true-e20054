using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayDetailInPopupWindow.Models;

namespace DisplayDetailInPopupWindow.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public PartialViewResult GridAction() {
            return PartialView("GridPartial", CustomerRepository.GetCustomers());
        }
    }
}
