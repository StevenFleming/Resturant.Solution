using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Food.Models;

namespace Food.Controllers
{
  public class ResturantsController : Controller
  {
    private readonly FoodContext _db;

    public ResturantsController(FoodContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Resturant> model = _db.Resturants.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Resturant resturant)
    {
      _db.Resturants.Add(resturant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Resturant thisCuisine = _db.Resturants.FirstOrDefault(resturants => resturants.Id == id);
      return View(thisCuisine);
    }

    public ActionResult Delete(int id)
    {
      var thisCuisine = _db.Resturants.FirstOrDefault(resturants => resturants.Id == id);
      return View(thisCuisine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCuisine = _db.Resturants.FirstOrDefault(resturant => resturant.Id == id);
      _db.Resturants.Remove(thisCuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}