using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace BoatOrder.Controllers
{
    public class CustomerController : Controller
    {
        UserDAL userDAL = new UserDAL();

        [AllowAnonymous]
        public IActionResult LoginPage()
        {
            //ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
     
      
        [HttpPost]
        public IActionResult LoginPage(Users users)
        {
            var result = userDAL.GetByEmail(users.EmailID);
            if (result != null)
            {
                if (result.Password == users.Password)
                {

                    //var claims = new List<Claim>();
                    //claims.Add(new Claim("EmailID", result.EmailID));
                    //claims.Add(new Claim(ClaimTypes.NameIdentifier, result.EmailID));
                    //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    //var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    //await HttpContext.SignInAsync(claimsPrincipal);
                    return View("CustomerLoggedIn", result);
                }
                else
                {
                    ViewBag.WrongPass = "Incorrect Password";
                    return View("LoginPage");
                  
                }
            }
            else
            {
                ViewBag.WrongEmailPass = "User does not exist";
                return View("LoginPage");
            }

        }

        public IActionResult CustomerLoggedIn(Users users,  int? id)
        {
            if(id!=null)
            {
                var cust = userDAL.GetByID(id);
                return View(cust);
            }
            else
            {
                //ViewBag.OrderPlacemsg = msg;
                return View(users);
            }
           

        }



        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Users users)
        {
            var result = userDAL.AddCustomer(users);
            if (result)
            {
                Console.WriteLine("Successfully Registered");
                return RedirectToAction("LoginPage");
            }
            else
            {
                Console.WriteLine("Unsuccessfull Registration");
                return View();
            }
        }
    }
}
