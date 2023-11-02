using FirstWebMVC.Models;
using  Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = "Welcome : " +ps.fname.ToUpper() + " - " + ps.ID + "-" +ps.Address;
        ViewBag.Nhapthongtin = strResult;
        return View();
    }
}