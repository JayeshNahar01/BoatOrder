using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
//using PagedList;
//using PagedList.Mvc;

namespace BoatOrder.Controllers
{
    public class BoatDetailsController : Controller
    {
        CustomerDAL customerDAL = new CustomerDAL();
        BoatDetailsDAL orderDAL = new BoatDetailsDAL();


        public IActionResult AddOrder(int CustomerID)
        {
            ViewBag.CustomerID = CustomerID;
            ViewBag.OrderDate = DateTime.Now;
            ViewBag.ShipmentDate = DateTime.Now.AddDays(7);
            return View();

        }

        [HttpPost]
        public IActionResult AddOrder(BoatDetails order)
        {

            var result = orderDAL.AddOrder(order);
            if (result)
            {

                return RedirectToAction("CustomerloggedIn", "Customer", new { id = order.UserID });
            }
            else
            {
                Console.WriteLine("Unsuccessfull Registration");
                return View();
            }

        }




   



        public IActionResult DeleteOrder(int orderID)
        {

            var result = orderDAL.GetByOrderID(orderID);
            //var result = subjectMasterBLL.DeleteSubject(subjectMaster);
            var deleteResult = orderDAL.DeleteOrder(result);
            if (deleteResult)
            {
                return RedirectToAction("DisplayOrderList", new { id = result.UserID } );
            }
            else
            {
                return View();
            }

        }
    }
}
