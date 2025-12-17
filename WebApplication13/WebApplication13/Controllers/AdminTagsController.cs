using Microsoft.AspNetCore.Mvc;
using WebApplication13.Data;
using WebApplication13.Models.ViewModels;

namespace WebApplication13.Controllers
{
    public class AdminTagsController : Controller
    {
        private BloggyDbcontext _bloggyDbcontext;
        private object bloggyDbcontext;

        public AdminTagsController(BloggyDbcontext bloggyDbcontext)
        {
            _bloggyDbcontext = bloggyDbcontext;

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
         public IActionResult Add(AddTagReq addTagReq)
        {
            bloggyDbcontext.Tagcs.Add();

            return View("Add");
        }

    }
}
