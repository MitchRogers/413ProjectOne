using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public interface ISignUpRepository
    {
        //make an IQuerable for both tables
        IQueryable<SignUp> SignUp { get; }

        IQueryable<TimeSlots>TimeSlots { get; }
    }
}
