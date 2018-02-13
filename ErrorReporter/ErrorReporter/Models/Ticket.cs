using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReporter.Models
{
    public class Ticket
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double SerialNumber { get; set; }
        public string Description { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
