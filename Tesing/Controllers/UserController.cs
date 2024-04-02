using Microsoft.AspNetCore.Mvc;
using Tesing.Models;

namespace Tesing.Controllers
{
    public class UserController : Controller
    {
        public Table_1 usrtbl = new Table_1();


        [HttpPost]

        public ActionResult About(Table_1 Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Home", "About");
        }
        [HttpGet]

        public ActionResult About()
        {
            return View(usrtbl);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
