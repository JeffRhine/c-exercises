using Exercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Web.Controllers
{
    public class ColorizerController : Controller
    {
        // GET: Colorizer
        public ActionResult ColorizedForm()
        {
            ColorizerModel model = new ColorizerModel();
            return View("ColorizedForm", model); //pass the model into the view
        }

        public ActionResult ColorizedFormResult(ColorizerModel input)
        {
            ColorizerModel model = input;
            return View("ColorizedFormResult", model);
        }
    }
}