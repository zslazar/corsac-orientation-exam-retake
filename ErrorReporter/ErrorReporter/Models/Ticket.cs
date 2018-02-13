using System;

namespace ErrorReporter.Models
{
    public class Ticket
    {
        public long Id { get; set; }
        public string Reporter { get; set; }
        public string Manufacturer { get; set; }
        public double SerialNumber { get; set; }
        public string Description { get; set; }
        public string ReportedAt { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
