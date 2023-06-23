using Microsoft.AspNetCore.Mvc;

namespace NenWebApp.Controllers;
public class BrowseController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}