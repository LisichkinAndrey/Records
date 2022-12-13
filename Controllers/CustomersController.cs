using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using records;

#nullable enable

namespace records.Controllers
{
    [ApiController]
    [Route("customers")]
    [ApiExplorerSettings(GroupName = "customers")]
    public class CustomersController : ControllerBase
    {

        CustomersBLL BLL = new CustomersBLL();

        [HttpPut]
        [Route("add")]
        public void AddCustomer(string name, string phoneNumber)
        {
            BLL.AddCustomer(name, phoneNumber);
        }

        [HttpGet]
        [Route("get_all")]
        public List<Customer>? GetAllCustomers()
        {
            return BLL.GetAllCustomers();
        }

        [HttpGet]
        [Route("get_by_num")]
        public Customer? GetCustomerByNumber(int customerNumber)
        {
            return BLL.GetCustomerByNumber(customerNumber);
        }

        [HttpGet]
        [Route("get_by_name")]
        public List<Customer>? GetCustomersByName(string name)
        {
            return BLL.GetCustomersByName(name);
        }

        [HttpGet]
        [Route("get_by_phone_number")]
        public List<Customer>? GetCustomersByPhoneNumber(string phoneNumber)
        {
            return BLL.GetCustomersByName(phoneNumber);
        }

        [HttpPatch]
        [Route("patch_name")]
        public void UpdateCustomerName(int partNumber, string newName)
        {
            BLL.UpdateCustomerName(partNumber, newName);
        }

        [HttpPatch]
        [Route("patch_phone_number")]
        public void UpdateCustomerPhoneNumber(int partNumber, string newPhoneNumber)
        {
            BLL.UpdateCustomerName(partNumber, newPhoneNumber);
        }

        [HttpDelete]
        [Route("delete_by_num")]
        public void RemoveCustomer(int partNumber)
        {
            BLL.RemoveCustomer(partNumber);
        }

    }
}
