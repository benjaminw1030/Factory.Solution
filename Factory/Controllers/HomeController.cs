using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}