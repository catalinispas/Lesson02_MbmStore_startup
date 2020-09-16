using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {

            var customer01 = new Customer("John", "Wick", "Hellerup", "012233", "tisACity", "+4550261232",new DateTime(1994,10,01));
            var customer02 = new Customer("Huanella", "Gonzales", "Skjøldhojkollegiet", "260182", "Brabrand", "+4552263212", new DateTime(1994,03,10));

            List<Customer> customerList = new List<Customer>();

            customerList.Add(customer01);
            customerList.Add(customer02);

            ViewBag.CustomerList = customerList;

            ViewBag.Customer01 = customer01;
            ViewBag.Customer02 = customer02;

            customer02.AddPhone("+052424242424242");


            return View();
        }
    }
}
