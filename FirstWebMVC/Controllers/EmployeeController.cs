using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers ;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Employee epm)
    {
        string strResult = "Xin chao : " + epm.fname.ToUpper() + " - " + epm.email + "-" + epm.ID + "-" + epm.Age;
        ViewBag.Nhandulieu = strResult;
        return View();
    }

}