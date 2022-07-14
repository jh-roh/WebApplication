using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    public class AccountController : Controller
    {
        List<User> users = new List<User>();
        
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        /// <summary>
        /// 회원 가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if(ModelState.IsValid)
            {
                users.Add(model);


            }

            return RedirectToAction("Index", "Home");

            return View();
        }
    }
}
