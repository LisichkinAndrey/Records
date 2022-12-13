using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    public class CustomersDAL
    {
        ApplicationContext db = new ApplicationContext();

        public void AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
        }

        public int GetLastNumber()
        {
            int? id = db.Customers.Max(r => r.Number);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<Customer>? GetAllCustomers()
        {
            List<Customer>? customers = db.Customers.ToList();
            return customers;
        }

        public Customer? GetCustomerByNumber(int customerNumber)
        {
            Customer? customer = (from r in db.Customers where r.Number == customerNumber select r).FirstOrDefault();
            return customer; 
        }

        public List<Customer>? GetCustomersByName(string name)
        {
            List<Customer>? customers = (from r in db.Customers where r.Name.Contains(name) select r).ToList();
            return customers;
        }

        public List<Customer>? GetCustomersByPhoneNumber(string phoneNumber)
        {
            List<Customer>? customers = (from r  in db.Customers where r.PhoneNumber.Contains(phoneNumber) select r).ToList();
            return customers;
        }

        public void UpdateCustomerName(int customerNumber, string newName)
        {
            Customer? customer = (from r in db.Customers where r.Number == customerNumber select r).FirstOrDefault();
            if (customer != null)
            {
                customer.Name = newName;
                db.SaveChanges();
            }
        }

        public void UpdateCustomerPhoneNumber(int customerNumber, string newPhoneNumber)
        {
            Customer? customer = (from r in db.Customers where r.Number == customerNumber select r).FirstOrDefault();
            if (customer != null)
            {
                customer.PhoneNumber = newPhoneNumber;
                db.SaveChanges();
            }
        }

        public void RemoveCustomer(int customerNumber)
        {
            Customer? customer = (from r in db.Customers where r.Number == customerNumber select r).FirstOrDefault();
            if (customer != null)
            {
                db.Customers.Remove(customer);
            }
        }
    }
}
