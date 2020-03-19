using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Food.Models;

namespace Food.Controllers
{
  public class CusisinesController : Controller
  {
    private readonly FoodContext _db;

    public CusisinesController(FoodContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cusisine> model = _db.Cusisines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cusisine cusisine)
    {
      _db.Cusisines.Add(cusisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cusisine thisCusisine = _db.Cusisines.FirstOrDefault(cusisines => cusisines.Id == id);
      return View(thisCusisine);
    }

    public ActionResult Delete(int id)
    {
      var thisCusisine = _db.Cusisines.FirstOrDefault(cusisines => cusisines.Id == id);
      return View(thisCusisine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCusisine = _db.Cusisines.FirstOrDefault(cusisine => cusisine.Id == id);
      _db.Cusisines.Remove(thisCusisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}