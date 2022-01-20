
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using CretaceousClient.Models;
using System.Collections.Generic;
using System.Linq;

namespace CretaceousClient.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly CretaceousClientContext _db;

    public AnimalsController(CretaceousClientContext db)
    {
      _db = db;
    }

    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return View(allAnimals);
    }

  }
}