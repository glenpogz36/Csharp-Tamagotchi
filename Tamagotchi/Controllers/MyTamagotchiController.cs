using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class MyTamagotchiController : Controller
  {

    [HttpGet("/mytamagotchi")]
    public ActionResult Index()
    {
     List<MyTamagotchi> allTamagotchis = MyTamagotchi.GetAll();
      return View(allTamagotchis);
    }

    [HttpGet("/mytamagotchi/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/mytamagotchi")]
    public ActionResult Create(string name)
    {
      MyTamagotchi myTamagotchi = new MyTamagotchi(name);
      return RedirectToAction("Index");
    }

     [HttpPost("/mytamagotchi/feed/{id}")]
     public ActionResult UpdateFood(int id)
     {
      MyTamagotchi myTamagotchi = MyTamagotchi.Find(id);
      myTamagotchi.GiveFood();
      myTamagotchi.ReduceStats();
      return View("Show",myTamagotchi);
     }
     [HttpPost("/mytamagotchi/sleep/{id}")]
     public ActionResult UpdateSleep(int id)
     {
      MyTamagotchi myTamagotchi = MyTamagotchi.Find(id);
      myTamagotchi.GiveSleep();
      myTamagotchi.ReduceStats();
      return View("Show",myTamagotchi);
     }
     [HttpPost("/mytamagotchi/attention/{id}")]
     public ActionResult UpdateAttention (int id)
     {
      MyTamagotchi myTamagotchi = MyTamagotchi.Find(id);
      myTamagotchi.GiveAttention();
      myTamagotchi.ReduceStats();
      return View("Show",myTamagotchi);
     }
     [HttpPost("/mytamagotchi/health/{id}")]
     public ActionResult UpdateHealth (int id)
     {
      MyTamagotchi myTamagotchi = MyTamagotchi.Find(id);
      myTamagotchi.GiveHealth();
      myTamagotchi.ReduceStats();
      return View("Show",myTamagotchi);
     }

    [HttpPost("/mytamagotchi/delete")]
    public ActionResult DeleteAll()
    {
      MyTamagotchi.ClearAll();
      return View();
    }

     [HttpGet("/mytamagotchi/{id}")]
    public ActionResult Show(int id)
    {
      MyTamagotchi myTamagotchi = MyTamagotchi.Find(id);
      return View(myTamagotchi);
    }

  }
}