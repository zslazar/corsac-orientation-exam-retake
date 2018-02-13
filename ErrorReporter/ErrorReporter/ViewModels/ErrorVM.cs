using ErrorReporter.Models;
using System.Collections.Generic;

namespace ErrorReporter.ViewModels
{
    public class ErrorVM
    {
        public List<User> Users { get; set; }
        public List<Ticket> Tickets { get; set; } 

        //public Ticket Manufacturer { get; set; }
        //public Ticket SerialNumber { get; set; }
        //public Ticket Description { get; set; }
    }
}
