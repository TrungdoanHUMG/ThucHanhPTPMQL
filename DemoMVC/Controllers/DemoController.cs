using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Menu()
       {
        return View();
       }

       [HttpPost]
       public IActionResult Menu(string fName )
       {
        string strResult = "Hello" + fName ;
        ViewBag.thongbao = strResult;
        return View();
       }
}
}