using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public interface ISignUpRepository
    {
        IQueryable<SignUp> SignUp { get; }

        IQueryable<TimeSlots>TimeSlots { get; }
    }
}
