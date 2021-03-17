using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private SignUpDbContext context;

        public HomeController(ILogger<HomeController> logger, SignUpDbContext con)
        {
            _logger = logger;
            context = con;
        }

        //Shows the Home Page view
        public IActionResult Index()
        {
            return View();
        }

        //Show the times where people can sign up to attend
        public IActionResult SignUp()
        {
            return View();
        }

        //when the form is requested, this will display the correct page
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        //When the form is posted, it will push data to database.
        [HttpPost]
        public IActionResult Form(SignUp formRes)
        {
            if (ModelState.IsValid)
            {
                context.SignUp.Add(formRes);
                context.SaveChanges();
                return View("Confirmation", formRes);
            }

            return View();

            
        }

        //Connects to database and shows the appointments that are scheduled.
        public IActionResult ViewAppointment()
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
    }
}
