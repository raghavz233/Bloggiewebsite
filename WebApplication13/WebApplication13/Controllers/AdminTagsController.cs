using Microsoft.AspNetCore.Mvc;

namespace WebApplication13.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName ("Add")]
         public IActionResult SubmitTag()
        {
            var name =Request.Form["Name"];

            return View("Add");
        }

    }
}
