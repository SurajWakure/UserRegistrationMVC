using Microsoft.AspNetCore.Mvc;
using UserRegistrationMVC.Models;
using UserRegistrationMVC.Service;
using System.Collections.Generic;

namespace UserRegistrationMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // ✅ Return View without passing a model (users loaded via AJAX)
        }

        [HttpPost]
        public IActionResult Register([FromBody] UserModel user) // ✅ Ensure JSON data binding
        {
            bool isRegistered = _userService.RegisterUser(user);
            return Json(new { success = isRegistered });
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            List<UserModel> users = _userService.GetAllUsers();
            return Json(users); // ✅ Return JSON response
        }
    }
}
