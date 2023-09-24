// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using NenWebApp.Data;
// using NenWebApp.Data.Entities;
//
// namespace NenWebApp.Controllers;
//
// public class ProgramController : Controller
// {
//     private readonly UserManager<ApplicationUser> _userManager;
//     private readonly AppDbContext _dbContext;
//
//     public ProgramController(UserManager<ApplicationUser> userManager, AppDbContext dbContext)
//     {
//         _dbContext = dbContext;
//         _userManager = userManager;
//     }
//     // GET
//     public IActionResult Index()
//     {
//         return View();
//     }
// }