using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class SignUp
    {
        //primary key
        [Key]
        [Required]
        public int GroupId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        public int GroupSize { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //phone number but not required
        [Phone]
        public string PhoneNumber { get; set; }

    }
}
