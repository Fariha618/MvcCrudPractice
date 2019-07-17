using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerApp.Models.Models;
using CustomerApp.DatabaseContext.DatabaseContext;

namespace CustomerApp.Repository.Repository
{
    public class CustomerRepository
    {
        CustomerDbContext db = new CustomerDbContext();

        public bool AddCustomer(Customer customer)
        {
            int isExecuted = 0;

            db.Customers.Add(customer);
            isExecuted = db.SaveChanges();

            if(isExecuted > 0)
            {
                return true;
            }

            return false;

        }

        public bool UpdateCustomer(Customer customer)
        {
            int isExecuted = 0;

            db.Entry(customer).State = EntityState.Modified;
            isExecuted = db.SaveChanges();

            if(isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public Customer GetByID(Customer customer)
        {
            Customer acustomer = db.Customers.FirstOrDefault(c => c.ID == customer.ID);
            return acustomer;
        }

        public bool DeleteCustomer(Customer customer)
        {
            int isExecuted = 0;

            Customer aCustomer = db.Customers.FirstOrDefault(c => c.ID == customer.ID);
            db.Customers.Remove(aCustomer);

            isExecuted = db.SaveChanges();

            if(isExecuted > 0)
            {
                return true;
            }

            return false;
        }
    }
}
