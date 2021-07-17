using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ReturnTypeController : Controller
    {
        public IActionResult Index()
        {
            return Content("No view needed!");
        }

        public IActionResult OkResult()
        {
            return Ok();
        }

        public IActionResult CreatedResult()
        {
            // tutaj można przerzucić header 
            return Created("https://www.google.com", new { query = "udemy" });
        }

        public IActionResult OkObjectResult()
        {
            var result = new OkObjectResult(new
            { message = "200 OK", currentDate = DateTime.Now });
            return result;
        }

        public IActionResult RedirectResult()
        {
            return Redirect("https://www.google.com");
        }
    }
}
