using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);
        }

        public IActionResult Details(int id)
        {
            return Ok("You have entered id = " + id);
        }

        [Route("App/Test")]
        public IActionResult MockAction()
        {
            return Ok("Mock action route works!");
        }

        [HttpPost]
        public IActionResult Post([FromHeader] string paramString)
        {
            return Ok($"Got parameter: {paramString}");
        }
    }
}
