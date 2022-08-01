using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.WebApi.Controllers
{
    public class CustomerBonusPointController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
