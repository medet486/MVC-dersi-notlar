using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_dersi_notlar.Models;

namespace MVC_dersi_notlar.Controllers;

public class PeopleController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutMe()
    {
        People people1= new People
        {
            Age = 23,
            Fullname = "Meedo Chinar",
            kimlik = "313131"
        };
         return View(people1);
    }
}