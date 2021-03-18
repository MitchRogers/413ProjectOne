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

        //creating an attribute that allows us to store and reference our DbContext
        private SignUpDbContext context;

        //brining in the variable and intializing it in the constructor
        public HomeController(ILogger<HomeController> logger, SignUpDbContext con)
        {
            _logger = logger;
            context = con;
        }

        //Shows the Index Page view
        public IActionResult Index()
        {
            return View();
        }

        //Show the times where people can sign up to attend seperated by Day, and if the appointment is available.
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

        //Creating an instance of a TimeSlot, and passing it in when posted.
        [HttpPost]
        public IActionResult SignUp(int TimeSlotId)
        {
            //creating a variable to pass through the ViewBag, this will allow us to pass the Time Slot information directly into the form.
            TimeSlots appointment = context.TimeSlots.Where(t => t.TimeSlotId == TimeSlotId).FirstOrDefault();
            ViewBag.TimeSlot = appointment;
            
            //directs the page to the Form view.
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
            //checks to see if the model is valid before chaning the database
            if (ModelState.IsValid)
            {
                context.SignUp.Add(formRes);
                context.SaveChanges();
                
                //if true, returns the index page after saving database
                return View("Index", formRes);
            }

            //if model is not valid, it will just return the same view, but show the errors on the form.
            return View();            
        }

        //Connects to database and shows the appointments that are scheduled.
        public IActionResult ViewAppointment()
        {
            //creating a list of AppointmentList that will allow us to display the data on our page.
            List<string> AppointmentList = new List<string>();

            //looping through all of the SignUp instnaces so we can display all of the tours in the database
            foreach (var x in context.SignUp)
            {
                //declaring a variable for TimeSlot that allows us to reference the correct TimeSlotId, and get the information in that model
                var y = context.TimeSlots.Where(a => a.TimeSlotId == x.TimeSlotId).FirstOrDefault();

                //A dynamic string that displays the information on our page
                AppointmentList.Add(string.Format($"Group Name: {x.GroupName} // Group Size: {x.GroupSize} // Day: {y.Day} // Time: {y.Time} // Contact: {x.Email} // Phone:  {x.PhoneNumber}"));
                
                //changing the IsAvailable attribute to false so that this specific appointment will no longer appear on our Schedule Tours Page
                y.IsAvailable = false;
                
                //Saves the Database.
                context.SaveChanges();

            }
            return View(AppointmentList);
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
