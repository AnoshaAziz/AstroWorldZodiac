using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstroWorldZodiac.Models.Entities
{
    public class GemStone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Appointment> Appointments { get; set; }
        
    }
}
