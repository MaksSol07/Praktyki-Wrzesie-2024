using Microsoft.AspNetCore.Mvc;
using StronaInternetowa.Models;
using System.Reflection;
using System.Diagnostics;
using System;

namespace StronaInternetowa.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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

    [Route("Recenzje-gier")]
    public IActionResult Reviews()
    {
        var reviews = new List<ReviewModel>
        {
            new ReviewModel { GameTitle = "Elden Ring", Rating = 9.8, ReviewText = "Arcydzielo od FromSoftware." },
            new ReviewModel { GameTitle = "God of War Ragnarok", Rating = 9.5, ReviewText = "Kratos powraca w epickiej sadze." }
        };

        return View(reviews);
    }

    [Route("nadchodzace-premiery")]
    public IActionResult UpcomingReleases()
    {
        var releases = new List<UpcomingReleaseModel>
        {
            new UpcomingReleaseModel { GameTitle = "Starfield", ReleaseDate = new DateTime(2024, 11, 12) },
            new UpcomingReleaseModel { GameTitle = "Hogwarts Legacy", ReleaseDate = new DateTime(2024, 12, 5) }
        };

        return View(releases);
    }
}
