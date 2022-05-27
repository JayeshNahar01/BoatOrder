using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;

namespace CustOrderWebApp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDAL ownerDAL = new CustomerDAL();
        BoatDetailsDAL orderDAL = new BoatDetailsDAL();
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(Customer customer)
        {
            var result = ownerDAL.GetByEmailID(customer.EmailID);

            if (result != null)
            {
                if (result.Password == customer.Password)
                {

                   
                    return View("OwnerloggedIn", result);
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

        public IActionResult CustomerloggedIn(Customer customer, int? id)
        {
            if (id != null)
            {
                var own = ownerDAL.GetByID(id);
                return View(own);
            }
            else
            {
                //ViewBag.OrderPlacemsg = msg;
                return View(customer);
            }


        }

        public IActionResult DeleteOrder(int orderID)
        {

            var result = orderDAL.GetByOrderID(orderID);
            //var result = subjectMasterBLL.DeleteSubject(subjectMaster);
            var deleteResult = orderDAL.DeleteOrder(result);
            if (deleteResult)
            {
                return RedirectToAction("ViewAllOrders", new { id = result.UserID });
            }
            else
            {
                return View();
            }
        }


    }
}
