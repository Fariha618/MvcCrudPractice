using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerApp.Models.Models;
using CustomerApp.BLL.BLL;

namespace CustomerApp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();
        private Customer customer = new Customer();

        // GET: Customer
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult AddCustomer()
        {
            customer.Code = "ZEK-395";
            customer.Name = "Zerin Khan";
            customer.Address = "Banani";
            customer.Email = "zerin.khan@gmail.com";
            customer.Contact = 01856298428;

            _customerManager.AddCustomer(customer);

            return View();
        }

        public ActionResult UpdateCustomer()
        {
            customer.ID = 7;

            Customer aCustomer = _customerManager.GetByID(customer);

            if (aCustomer != null)
            {
                aCustomer.Code = "SPH-109";
                aCustomer.Email = "fatema_pushpo@yahoomail.com";
                aCustomer.Contact = 01716850073;
                _customerManager.UpdateCustomer(aCustomer);

            }

            return View();
        }

        public ActionResult DeleteCustomer()
        {
            customer.ID = 14;

            _customerManager.DeleteCustomer(customer);
           
            return View();
        }
    }
}