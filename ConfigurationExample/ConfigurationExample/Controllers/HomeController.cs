//namespace ConfigurationExample.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly IConfiguration _configuration;
//        public HomeController(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }
//        [Route("/")]
//        public IActionResult Index()
//        {
//            ViewBag.ClientID = _configuration["weatherapi : ClientID"];
//            ViewBag.ClientSecrete = _configuration.GetValue("weatherapi : ClientSecret", "the default key");
//            return View();
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        //private field
        private readonly Weatherapi _options;

        //constructor
        public HomeController(IOptions<Weatherapi> weatherApiOptions)
        {
            _options = weatherApiOptions.Value;
        }

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.ClientID = _options.ClientID;
            ViewBag.ClientSecret = _options.ClientSecret;

            return View();
        }
    }
}