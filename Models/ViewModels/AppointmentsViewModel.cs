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
        public IEnumerable<TimeSlots> Monday { get; set; }
        public IEnumerable<TimeSlots> Tuesday { get; set; }
        public IEnumerable<TimeSlots> Wednesday { get; set; }
        public IEnumerable<TimeSlots> Thursday { get; set; }
        public IEnumerable<TimeSlots> Friday { get; set; }
        public IEnumerable<TimeSlots> Saturday { get; set; }
    }
}
