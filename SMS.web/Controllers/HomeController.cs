using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.web.Models;

namespace SMS.web.Controllers
{

    public class HomeController : Controller
    {
    public IActionResult Index()
    {
        return View();

    }

        public IActionResult About()
    {

        //Construct viewmodel
        var about = new AboutViewModel
        {
            Formed = new DateTime(2020,01,01),

            Title = new String("Web Based Application Development COM741"),

            Message = new String("Teaching Staff Aiden McCaughey, Senior Lecturer School of Computing Engineering & Intelligent Systems")

        };

        return View(about);

    }

    public IActionResult Privacy()
    {
        return View();

    }
    
    }

}
