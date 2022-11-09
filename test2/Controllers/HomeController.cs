using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test2.Models;

namespace test2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(InformationViewModel model)
    {
        string name = "Ramesh";
        string address = "Baitadi";
        string phone = "9874748723";

        // // Using ViewBag
        // ViewBag.name = name;
        // ViewBag.address = address;
        // ViewBag.phone = phone;

        // // Using ViewData
        // ViewData["name"] = name;
        // ViewData["address"] = address;
        // ViewData["phone"] = phone;

        // Using model
        model.Name = name;
        model.Address = address;
        model.Phone = phone;

        return View(model);
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

    public ActionResult Addition(AdditionViewModel model)
    {
        model.Result = model.A + model.B;
        return View(model);
    }

    public ActionResult SumOfDigits(SumOfDigitsViewModel model)
    {
        int num = model.IP;
        int r, sum = 0;
        while(num > 0) {
            r = num % 10;
            sum += r;
            num /= 10;
        }

        model.Result = sum;
        return View(model);
    }
}
