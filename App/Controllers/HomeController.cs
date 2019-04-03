using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repo.IEmployee employee;

        public HomeController(Repo.IEmployee _employee)
        {
            employee = _employee;
        }

        public IActionResult Index()
        {
            var ViewModel = employee.FetchEmployeeList();
            return View(ViewModel);

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
}
