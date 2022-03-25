using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TreatShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace TreatShop.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly TreatShopContext _db;

    public FlavorsController(TreatShopContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      ViewBag.PageTitle = "Flavors";
      return View(model);
    }
  }
}