using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KaterinaPostStuff.Models;
using KaterinaPostStuff.Providers;

namespace KaterinaPostStuff.Controllers
{
    public class HomeController : Controller
    {
        private OrderProvider _orderProvider;

        public HomeController(OrderProvider orderProvider)
        {
            _orderProvider = orderProvider;
        }

        public IActionResult Index()
        {
            var orders = _orderProvider.GetAllOrders();
            return View(orders);
        }

        public IActionResult DoStuff(int id)
        {
            var order = _orderProvider.GetOrderById(id);

            if (order == null)
            {

            }

            // Call the SProc, do whatever

            return View(order);
        }
    }
}
