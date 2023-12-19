using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using todo_list.Models;

namespace todo_list.Controllers;

public class ToDoListController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ToDoListController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Edit()
    {
            
         return View();
    }

    public IActionResult Remove()
    {
        return View();
    }

}
