using MattyEditors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MattyEditors.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id = 0)
        {
            ParentModel model;
            if (id != 0 && false /* to stop it from hitting */)
            {
                // Edit
                // Load model from DB model = db.Parents.Find(id);
            }
            else
            {
                // Create
                model = new ParentModel();
            }

            // Ensure we have a new editor row present always
            model.Children.Add(new ChildModel());

            return View(model);
        }

        public ActionResult Index(ParentModel model)
        {
            if (ModelState.IsValid)
            {
                // Do saving and stuff

                foreach (var childModel in model.Children)
                {
                    // See if we should be adding this or saving?
                    if (childModel.Id == 0)
                    {
                        // Insert / Add, check if there is any data first (check required fields)
                        if (!string.IsNullOrWhiteSpace(childModel.MyProperty))
                        {
                            // Insert into DB now
                        }
                    }
                    else
                    {
                        // 
                    }
                }

                // Normally we'd return here to read from DB but for sample we're just going to fall through and mimic the base action
                //return RedirectToAction(nameof(Index), new { model.Id });
            }
            
            // Ensure we have a new editor row present always
            model.Children.Add(new ChildModel());

            return View(model);
        }
    }
}