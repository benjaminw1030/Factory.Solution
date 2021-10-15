using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult All()
    {
      dynamic model = new ExpandoObject();
      model.Machines = _db.Machines.ToList();
      model.Engineers = _db.Engineers.ToList();
      return View(model);
    }
  }
}