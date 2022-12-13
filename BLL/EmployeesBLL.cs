using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    [System.ComponentModel.DataObject]
    public class EmployeesBLL
    {
        private EmployeesDAL DAL = new EmployeesDAL();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddEmployee(string name, string phoneNumber, int experience, string position, string passportNumber)
        {
            DAL.AddEmployee(new Employee
            {
                Number = DAL.GetLastNumber() + 1,
                Name = name,
                PhoneNumber = phoneNumber,
                experience = experience,
                Position = position,
                PassportNumber = passportNumber
            });
        }

        public List<Employee>? GetAllEmployees()
        {
            return DAL.GetAllEmployees();
        }

        public Employee? GetEmployeeByNumber(int employeeNumber)
        {
            return DAL.GetEmployeeByNumber(employeeNumber);
        }

        public List<Employee>? GetEmployeesByName(string name)
        {
            return DAL.GetEmployeesByName(name);
        }

        public List<Employee>? GetEmployeesByPhoneNumber(string phoneNumber)
        {
            return DAL.GetEmployeesByName(phoneNumber);
        }

        public List<Employee>? GetEmployeesByExpierience(int experience)
        {
            return DAL.GetEmployeesByExpierience(experience);
        }

        public List<Employee>? GetEmployeesByPosition(string position)
        {
            return DAL.GetEmployeesByPosition(position);
        }

        public void UpdateEmployeeName(int employeeNumber, string newName)
        {
            DAL.UpdateEmployeeName(employeeNumber, newName);
        }

        public void UpdateEmployeePhoneNumber(int employeeNumber, string newPhoneNumber)
        {
            DAL.UpdateEmployeeName(employeeNumber, newPhoneNumber);
        }


        public void UpdateEmployeeexperience(int employeeNumber, int newexperience)
        {
            DAL.UpdateEmployeeexperience(employeeNumber, newexperience);
        }

        public void UpdateEmployeePosition(int employeeNumber, string newPosition)
        {
            DAL.UpdateEmployeePosition(employeeNumber, newPosition);
        }

        public void RemoveEmployee(int employeeNumber)
        {
            DAL.RemoveEmployee(employeeNumber);
        }
    }
}
