using Microsoft.AspNetCore.Mvc;

namespace NenWebApp.Controllers;
public class WorkoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}