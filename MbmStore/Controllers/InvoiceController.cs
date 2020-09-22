using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Invoice> invoices;
            invoices = Repository.Invoices.OfType<Invoice>().ToList();
            ViewBag.Invoices = invoices;

            return View();
        }
    }
}
