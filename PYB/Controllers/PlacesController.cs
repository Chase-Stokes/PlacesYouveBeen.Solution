using Microsoft.AspNetCore.Mvc;
using PYB.Models;
using System.Collections.Generic;

namespace PYB.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Places> allPlaces = Places.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string description)
    {
      Places myPlace = new Places(cityName, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Places foundPlace = Places.Find(id);
      return View(foundPlace);
    }
  }
}