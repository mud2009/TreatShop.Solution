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

  }
}