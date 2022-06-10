using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    // root route
    [HttpGet]
    public IActionResult Index()
    {
        string message = "Lorem ipsum dolor sit amet...";
        return View("Index", message);
    }

    // numbers route
    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
        int [] numbers = new int[] {4, 8, 13, 52, 43};
        return View ("numbers", numbers);
    }

    // multiple users route
    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> users = new List<User>();
        users.Add(new User("Josh", "Davidson"));
        users.Add(new User("Logan", "Domingo"));
        users.Add(new User("Nathan", "Prater"));
        users.Add(new User("Michael", "Mason"));
        return View("users", users);

    }

    // single user route
    [HttpGet("user")]
    public IActionResult OneUser()
    {
        User someUser = new User("John", "Doe");
        return View("user", someUser);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
