using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    [System.ComponentModel.DataObject]
    public class CustomersBLL
    {
        private CustomersDAL DAL = new CustomersDAL();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddCustomer(string name, string phoneNumber)
        {
            DAL.AddCustomer(new Customer { 
                Number = DAL.GetLastNumber() + 1, 
                Name = name, 
                PhoneNumber = phoneNumber });
        }

        public List<Customer>? GetAllCustomers()
        {
            return DAL.GetAllCustomers();
        }

        public Customer? GetCustomerByNumber(int customerNumber)
        {
            return DAL.GetCustomerByNumber(customerNumber);
        }

        public List<Customer>? GetCustomersByName(string name)
        {
            return DAL.GetCustomersByName(name);
        }

        public List<Customer>? GetCustomersByPhoneNumber(string phoneNumber)
        {
            return DAL.GetCustomersByName(phoneNumber);
        }

        public void UpdateCustomerName(int customerNumber, string newName)
        {
            DAL.UpdateCustomerName(customerNumber, newName);
        }

        public void UpdateCustomerPhoneNumber(int customerNumber, string newPhoneNumber)
        {
            DAL.UpdateCustomerName(customerNumber, newPhoneNumber);
        }

        public void RemoveCustomer(int customerNumber)
        {
            DAL.RemoveCustomer(customerNumber);
        }
    }
}
