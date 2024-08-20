using Microsoft.AspNetCore.Mvc;

namespace To_Do_List.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
