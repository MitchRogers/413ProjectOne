using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    //this will be using seed data for hardcoding purposes.
    public class TimeSlots
    {
       //where do these two tables connect!
       [Key]
       [Required]
       public int TimeSlotId { get; set; }

        [Required]
        public string Time { get; set; }

        //this default value is true so the button for signup will be open
        [Required]
        public bool IsAvailable { get; set; } = true;

        [Required]
        public string Day { get; set; }
    }
}
