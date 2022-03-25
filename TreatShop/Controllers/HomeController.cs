using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TreatShop.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TreatShop.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatShopContext _db;
    public HomeController(TreatShopContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.AllFlavors = _db.Flavors.ToList();
      ViewBag.AllTreats = _db.Treats.ToList();
      ViewBag.PageTitle = "Treat Shop Tracker";
      return View();
    }
  }
}