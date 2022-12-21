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
    [Route("employees")]
    [ApiExplorerSettings(GroupName = "employees")]
    public class EmployeesController : ControllerBase
    {

        EmployeesBLL BLL = new EmployeesBLL();

        [HttpPut]
        [Route("add")]
        public void AddEmployee(string name, string phoneNumber, int experience, string position, string passportNumber)
        {
            BLL.AddEmployee(name, phoneNumber, experience, position, passportNumber);
        }

        [HttpGet]
        [Route("get_all")]
        public List<Employee>? GetAllEmployees()
        {
            return BLL.GetAllEmployees();
        }

        [HttpGet]
        [Route("get_by_num")]
        public Employee? GetEmployeeByNumber(int employeeNumber)
        {
            return BLL.GetEmployeeByNumber(employeeNumber);
        }

        [HttpGet]
        [Route("get_by_name")]
        public List<Employee>? GetEmployeesByName(string name)
        {
            return BLL.GetEmployeesByName(name);
        }

        [HttpGet]
        [Route("get_by_phone_number")]
        public List<Employee>? GetEmployeesByPhoneNumber(string phoneNumber)
        {
            return BLL.GetEmployeesByName(phoneNumber);
        }

        [HttpGet]
        [Route("get_by_experience")]
        public List<Employee>? GetEmployeesByExpierience(int experience)
        {
            return BLL.GetEmployeesByExpierience(experience);
        }

        [HttpGet]
        [Route("get_by_position")]
        public List<Employee>? GetEmployeesByPosition(string position)
        {
            return BLL.GetEmployeesByPosition(position);
        }

        [HttpPatch]
        [Route("patch_name")]
        public void UpdateEmployeeName(int employeeNumber, string newName)
        {
            BLL.UpdateEmployeeName(employeeNumber, newName);
        }

        [HttpPatch]
        [Route("patch_phone_number")]
        public void UpdateEmployeePhoneNumber(int employeeNumber, string newPhoneNumber)
        {
            BLL.UpdateEmployeeName(employeeNumber, newPhoneNumber);
        }

        [HttpDelete]
        [Route("delete_by_num")]
        public void RemoveEmployee(int employeeNumber)
        {
            BLL.RemoveEmployee(employeeNumber);
        }

    }
}
