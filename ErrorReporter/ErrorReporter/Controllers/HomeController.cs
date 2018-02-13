using ErrorReporter.Models;
using ErrorReporter.Repositories;
using ErrorReporter.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ErrorReporter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private ErrorRepository errorRepository;

        public HomeController(ErrorRepository errorRepository)
        {
            this.errorRepository = errorRepository;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            ErrorVM errorVM = new ErrorVM();
            errorVM.Users = errorRepository.GetUsers();
            errorVM.Tickets = errorRepository.GetTickets();
            return View(errorVM);
        }
        
        [HttpGet("list")]
        public IActionResult List()
        {
            ErrorVM errorVM = new ErrorVM();
            errorVM.Users = errorRepository.GetUsers();
            errorVM.Tickets = errorRepository.GetTickets();

            return View(errorVM);
        }

        [HttpPost("report")]
        public IActionResult Report(Ticket ticket)
        {
            errorRepository.ReportError(ticket);
            return Redirect("list");
        }

        [HttpPost("complete/{id}")]
        public IActionResult Complete([FromBody] long id)
        {
            errorRepository.DeleteTicket(id);
            return Redirect("list");
        }

        [HttpGet("list/query")]
        public IActionResult ListQuery(string manufacturer, string reporter)
        {
            return Json(new { result = "ok", tickets = errorRepository.GetFilteredTicketsByManufacturer(manufacturer) });
            //return Json(new { result = "ok", tickets = errorRepository.GetFilteredTicketsByManufacturer(reporter) });
        }
    }
}
