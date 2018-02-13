using ErrorReporter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReporter.Entities
{
    public class ErrorContext : DbContext
    {
        public ErrorContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
