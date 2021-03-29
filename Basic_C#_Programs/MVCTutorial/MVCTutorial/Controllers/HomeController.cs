using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //log to a text file
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\kskel\html-css-projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\MVCTutorial\Logs\log.txt", text);

            //this demonstrates getting a random number and then displaying a different view if it's greater than a certain number
            //Random rnd = new Random(10);
            //var num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}


            //return View();
            //you can use content when you want to return nothing
            //return Content("");

            //you can return a redirect
            //this sends it down the Contact action 
            //this is different than returning a different view
            //It takes you to the actual page
            //return RedirectToAction("Contact");

            //List<string> names = new List<string>
            //{
            //    "Jessie",
            //    "Adam",
            //    "Brett"
            //};
            //return View(names);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");
            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}