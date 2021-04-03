using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance2.Models;
using CarInsurance2.ViewModel;

namespace CarInsurance2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quotes = db.Insurees;
                var quoteVMs = new List<QuoteVM>();
                foreach (var quote in quotes)
                {
                    var quoteVM = new QuoteVM();
                    quoteVM.FirstName = quote.FirstName;
                    quoteVM.LastName = quote.LastName;
                    quoteVM.EmailAddress = quote.EmailAddress;
                    quoteVM.Quote = quote.Quote;
                    quoteVMs.Add(quoteVM);
                }
                return View(quoteVMs);
            }
        }
    }
}