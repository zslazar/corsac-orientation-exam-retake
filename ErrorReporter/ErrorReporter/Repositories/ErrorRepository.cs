using ErrorReporter.Entities;
using ErrorReporter.Models;
using System.Collections.Generic;
using System.Linq;

namespace ErrorReporter.Repositories
{
    public class ErrorRepository
    {
        private ErrorContext errorContext;

        public ErrorRepository(ErrorContext errorContext)
        {
            this.errorContext = errorContext;
        }

        public List<User> GetUsers()
        {
            return errorContext.Users.ToList();
        }
        
        public List<Ticket> GetTickets()
        {
            return errorContext.Tickets.ToList();
        }

        public List<Ticket> GetFilteredTicketsByManufacturer(string manufacturer)
        {            
            List<Ticket> FilteredList = new List<Ticket>();

            if (manufacturer.Equals(manufacturer))
            {
                FilteredList = GetTickets().Where(f => f.Manufacturer == manufacturer).ToList();                    
            }                      
            return FilteredList;
        }

        public List<Ticket> GetFilteredTicketsByReporter(string reporter)
        {
            List<Ticket> FilteredList = new List<Ticket>();

            if (reporter.Equals(reporter))
            {
                FilteredList = GetTickets().Where(f => f.Reporter == reporter).ToList();
            }
            return FilteredList;
        }

        public void ReportError(Ticket ticket)
        {
            errorContext.Tickets.Add(ticket);
            errorContext.SaveChanges();            
        }

        public void DeleteTicket(long id)
        {
            Ticket data = errorContext.Tickets.FirstOrDefault(d => d.Id == id);
            errorContext.Tickets.Remove(data);
            errorContext.SaveChanges();            
        }
    }
}
