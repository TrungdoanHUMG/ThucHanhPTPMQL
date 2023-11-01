using  Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fname, string ID)
    {
        string strResult = "Welcome : " + fname.ToUpper() + " - " + ID;
        ViewBag.Nhapthongtin = strResult;
        return View();
    }
}