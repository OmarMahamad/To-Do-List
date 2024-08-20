using Microsoft.AspNetCore.Mvc;
using To_Do_List.Data;
using To_Do_List.Models;

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
        
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
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
        public IActionResult SignUp(UserModel user)
        {
            if(ModelState.IsValid)
            {
                var check = _dbContext.Users.Where(u=>u.Email==user.Email);
                if (check==null)
                {
                    _dbContext.Users.Add(user);
                    _dbContext.SaveChanges();
                    return RedirectToAction("Home", "Tasks");
                }
                ViewBag.Email = "The Email is eardy Register";
                return View();
            }
            return View();
        }





    }
}
