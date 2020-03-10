using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
using System.Collections.Generic;

namespace Shipping.Controllers
{
  public class ParcelsController : Controller
  {
    public List <Parcel> allParcels = Parcel.GetAll();

    [HttpGet("/parcel/list")]
    public ActionResult List()
    {
      return View(allParcels);
    }

    [HttpGet("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcel/list")]
    public ActionResult CreateParcel(int length, int width, int height, int weight, string destination)
    {
      Parcel newParcel = new Parcel(length, width, height, weight, destination);
      return RedirectToAction("List");
    }

    [HttpGet("/parcel/finalOrder")]
    public ActionResult Order()
    {
      return View(Parcel.CalculateFinalCost());
    }

  }
}