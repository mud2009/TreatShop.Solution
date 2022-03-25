using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TreatShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace TreatShop.Controllers
{
  public class TreatsController : Controller
  {
    private readonly TreatShopContext _db;

    public TreatsController(TreatShopContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}