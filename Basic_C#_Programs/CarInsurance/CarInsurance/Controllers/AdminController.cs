using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quotes = db.Tables;
                var quotesVMs = new List<QuotesVM>();
                foreach (var quote in quotesVMs)
                {
                    var quoteVM = new QuotesVM();
                    quoteVM.FirstName = quote.FirstName;
                    quoteVM.LastName = quote.LastName;
                    quoteVM.EmailAddress = quote.EmailAddress;
                    quotesVMs.Add(quoteVM);
                }
                return View(quotesVMs);
            }
        }

    }
}
