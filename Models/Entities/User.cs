using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AstroWorldZodiac.Models.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Feedback> Feedbacks { get; set; }
    }
}
