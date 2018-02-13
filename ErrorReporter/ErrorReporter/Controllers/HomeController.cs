using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ErrorReporter.Repositories;
using ErrorReporter.ViewModels;

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

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
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
        public IActionResult Report()
        {
            return Ok();
        }

        [HttpGet("list/query")]
        public IActionResult ListQuery()
        {
            return Ok();
        }

    }
}
