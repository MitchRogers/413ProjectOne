using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectOne.Models;
using ProjectOne.Models.ViewModels;
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
        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new AppointmentsViewModel
            {
                Monday = context.TimeSlots.Where(x => x.Day == "Monday" && x.IsAvailable == true),
                Tuesday = context.TimeSlots.Where(x => x.Day == "Tuesday" && x.IsAvailable == true),
                Wednesday = context.TimeSlots.Where(x => x.Day == "Wednesday" && x.IsAvailable == true),
                Thursday = context.TimeSlots.Where(x => x.Day == "Thursday" && x.IsAvailable == true),
                Friday = context.TimeSlots.Where(x => x.Day == "Friday" && x.IsAvailable == true),
                Saturday = context.TimeSlots.Where(x => x.Day == "Saturday" && x.IsAvailable == true)
            });
        }

        [HttpPost]
        public IActionResult SignUp(int TimeSlotId)
        {
            TimeSlots appointment = context.TimeSlots.Where(t => t.TimeSlotId == TimeSlotId).FirstOrDefault();
            ViewBag.TimeSlot = appointment;
            return View("Form");
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
            List<string> AppointmentList = new List<string>();

            foreach (var x in context.TimeSlots)
            {
                if (x.TimeSlotId != null)
                {
                    var y = context.SignUp.Where(a => a.TimeSlotId == x.TimeSlotId).FirstOrDefault();

                    AppointmentList.Add($"Group Name: {y.GroupName} Group Size: {y.GroupSize} Day: {x.Day} Time: {x.Time} Contact: {y.Email} Phone:  {y.PhoneNumber}");
                }
            }
            return View(context.SignUp);
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
