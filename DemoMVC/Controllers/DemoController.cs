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
       public IActionResult Menu(string fName , string ABC )
       {
        string strResult = "Hello" + fName + "-" + ABC ; 
        ViewBag.thongbao = strResult;
        return View();
       }
}
}