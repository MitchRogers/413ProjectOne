using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class EFSignUpRepository
    {
        public class EFSignupRepository : ISignUpRepository
        {
            private SignUpDbContext _context;

            //constructor
            public EFSignupRepository (SignUpDbContext context)
            {
                //pass context into the private context
                _context = context;
            }

            //SignUp info is set to the context
            //TimeSlots is also set to the context 
            //we can get at both the tables now.
            public IQueryable<SignUp> SignUp => _context.SignUp;
            public IQueryable<TimeSlots> TimeSlots => _context.TimeSlots;
        }
    }
}
