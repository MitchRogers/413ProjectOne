using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models.ViewModels
{
    public class AppointmentsViewModel
    {
        public IEnumerable<SignUp> SignUp { get; set; }
        public IEnumerable<TimeSlots> TimeSlots { get; set; }
    }
}
