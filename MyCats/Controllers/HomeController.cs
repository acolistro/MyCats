using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cats.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/index")]
    public ActionResult Index()
    {
      return View();
    }
  }
}