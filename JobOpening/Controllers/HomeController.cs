using Microsoft.AspNetCore.Mvc;

namespace JobOpening.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}