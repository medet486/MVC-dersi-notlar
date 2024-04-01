using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Week2.Models;

namespace Week2.Controllers;

public class RegistrationController : Controller
{
    public IActionResult Index(){
        return View();
    }
}