using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstroWorldZodiac.Models.Entities;
using Microsoft.AspNetCore.Authentication;

namespace AstroWorldZodiac.Models
{
    public class AppointmentStatusViewModel
    {
        public List<Appointment> Appointments { get; set; }
    }
}
