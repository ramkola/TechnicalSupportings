using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PawelMultipleEditor.Models;

namespace PawelMultipleEditor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var parent = new SampleParent
            {
                Name = "Hello I am a Parent",
                Children = new List<SampleChild>
                {
                    new SampleChild { Id = 1, Column1 = "Hello", Column2 = "I am ID 1",  Column3 = 5, Column4 = DateTime.MinValue },
                    new SampleChild { Id = 2, Column1 = "I AM FROM THE FUTURE", Column2 = "hehe",  Column3 = 999, Column4 = DateTime.MaxValue },
                    new SampleChild { Id = 4, Column1 = "OMG ID 4", Column2 = "Weeeee",  Column3 = -50, Column4 = DateTime.Now },
                }
            };
            return View(parent);
        }

        [HttpPost]
        public IActionResult Index(SampleParent model)
        {
            if (ModelState.IsValid)
            {
                // .. Save, debug here and see mappings correct in model
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
