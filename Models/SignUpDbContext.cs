using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    //inherits from the DbContext file or session of the database
    public class SignUpDbContext : DbContext
    {
        //constructor
        public SignUpDbContext(DbContextOptions<SignUpDbContext> options) : base (options)
        {

        }

        //create a set of the SignUp information so it can be displayed
        public DbSet<SignUp> SignUp { get; set; }

        //Not sure if this is needed but just in case
        public DbSet<TimeSlots> TimeSlots { get; set; }
    }
}

