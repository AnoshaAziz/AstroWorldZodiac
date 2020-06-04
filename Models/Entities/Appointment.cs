using System;
using System.ComponentModel.DataAnnotations;

namespace AstroWorldZodiac.Models.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        public string Category { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int? GemStoneId { get; set; }
        public GemStone GemStone { get; set; }
    }

}
