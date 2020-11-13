using System;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Controllers
{
    public class UserController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View(); 
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }

        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {

        }
    }
}
