using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerTransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
