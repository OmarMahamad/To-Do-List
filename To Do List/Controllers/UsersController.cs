using Microsoft.AspNetCore.Mvc;
using To_Do_List.Data;

namespace To_Do_List.Controllers
{
    public class UsersController : Controller
    {
        private readonly ToDoListDbContext _dbContext;
        public UsersController(ToDoListDbContext dbContext)
        {
            _dbContext= dbContext;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email,string PassWord)
        {
            var user=_dbContext.Users.Where(u=>u.Email==Email && u.Password==PassWord).FirstOrDefault();
            if (user!=null)
            {
                return RedirectToAction("Home", "Tasks");
            }
            return View();
        }

        [HttpPost]
        public IActionResult SignUp()
        {
            
            return View();
        }







    }
}
