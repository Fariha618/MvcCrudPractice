using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerApp.Models.Models;
using CustomerApp.Repository.Repository;

namespace CustomerApp.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }

        public Customer GetByID(Customer customer)
        {
            return _customerRepository.GetByID(customer);
        }

        public bool DeleteCustomer(Customer customer)
        {
            return _customerRepository.DeleteCustomer(customer);
        }
    }
}
