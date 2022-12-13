using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    public class EmployeesDAL
    {
        ApplicationContext db = new ApplicationContext();

        public void AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
        }

        public int GetLastNumber()
        {
            int? id = db.Employees.Max(r => r.Number);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<Employee>? GetAllEmployees()
        {
            List<Employee>? employees = db.Employees.ToList();
            return employees;
        }

        public Employee? GetEmployeeByNumber(int employeeNumber)
        {
            Employee? employee = (from r in db.Employees where r.Number == employeeNumber select r).FirstOrDefault();
            return employee;
        }

        public List<Employee>? GetEmployeesByName(string name)
        {
            List<Employee>? employees = (from r in db.Employees where r.Name.Contains(name) select r).ToList();
            return employees;
        }

        public List<Employee>? GetEmployeesByPhoneNumber(string phoneNumber)
        {
            List<Employee>? employees = (from r in db.Employees where r.PhoneNumber.Contains(phoneNumber) select r).ToList();
            return employees;
        }

        public List<Employee>? GetEmployeesByExpierience(int experience)
        {
            List<Employee>? employees = (from r in db.Employees where r.experience == experience select r).ToList();
            return employees;
        }

        public List<Employee>? GetEmployeesByPosition(string position)
        {
            List<Employee>? employees = (from r in db.Employees where r.PhoneNumber.Contains(position) select r).ToList();
            return employees;
        }

        public void UpdateEmployeeName(int employeeNumber, string newName)
        {
            Employee? employee = (from r in db.Employees where r.Number == employeeNumber select r).FirstOrDefault();
            if (employee != null)
            {
                employee.Name = newName;
                db.SaveChanges();
            }
        }

        public void UpdateEmployeePhoneNumber(int employeeNumber, string newPhoneNumber)
        {
            Employee? employee = (from r in db.Employees where r.Number == employeeNumber select r).FirstOrDefault();
            if (employee != null)
            {
                employee.PhoneNumber = newPhoneNumber;
                db.SaveChanges();
            }
        }

        public void UpdateEmployeeexperience(int employeeNumber, int newexperience)
        {
            Employee? employee = (from r in db.Employees where r.Number == employeeNumber select r).FirstOrDefault();
            if (employee != null)
            {
                employee.experience = newexperience;
                db.SaveChanges();
            }
        }

        public void UpdateEmployeePosition(int employeeNumber, string newPosition)
        {
            Employee? employee = (from r in db.Employees where r.Number == employeeNumber select r).FirstOrDefault();
            if (employee != null)
            {
                employee.Position = newPosition;
                db.SaveChanges();
            }
        }

        public void RemoveEmployee(int employeeNumber)
        {
            Employee? employee = (from r in db.Employees where r.Number == employeeNumber select r).FirstOrDefault();
            if (employee != null)
            {
                db.Employees.Remove(employee);
            }
        }
    }
}
