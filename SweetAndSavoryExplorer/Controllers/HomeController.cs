using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SweetAndSavoryExplorer.Models;

namespace SweetAndSavoryExplorer.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetAndSavoryExplorerContext _db;

    public HomeController(SweetAndSavoryExplorerContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Flavors = _db.Flavors.ToList();
      ViewBag.Treats = _db.Treats.ToList();
      return View();
    }

  }
}