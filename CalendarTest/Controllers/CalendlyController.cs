using Microsoft.AspNetCore.Mvc;

namespace CalendarTest.Controllers
{
    public class CalendlyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ScheduleEvent()
        {
            return View();
        }
    }
}
