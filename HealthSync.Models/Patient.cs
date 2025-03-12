using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSync.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string? StreetAddress { get; set; }
        public string? Baranggay { get; set; }
        public string? Province { get; set; }  
        public string? Region { get; set; } 
        public string? Municipality { get; set; }
    }
}
