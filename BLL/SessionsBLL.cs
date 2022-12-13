using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    [System.ComponentModel.DataObject]
    public class SessionsBLL
    {
        private SessionsDAL DAL = new SessionsDAL();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddSession(string name, DateTime duration, int customerNumber, int employeeNumber, int recordTypeNumber, int discountCardNumber, int paymentNumber)
        {
            DAL.AddSession(new Session
            {
                Number = DAL.GetLastNumber() + 1,
                SessionDateTime = DateTime.Now,
                CustomerNumber = customerNumber,
                EmployeeNumber = employeeNumber,
                RecordTypeNumber = recordTypeNumber,
                DiscountCardNumber = discountCardNumber,
                PaymentNumber = paymentNumber
            });
        }

        public List<Session>? GetAllSessions()
        {
            return DAL.GetAllSessions();
        }

        public Session? GetSessionByNumber(int customerNumber)
        {
            return DAL.GetSessionByNumber(customerNumber);
        }

        public List<Session>? GetSessionsByCustomerNumber(int customerNumber)
        {
            return DAL.GetSessionsByCustomerNumber(customerNumber);
        }

        public List<Session>? GetSessionsByEmployeeNumber(int employeeNumber)
        {
            return DAL.GetSessionsByCustomerNumber(employeeNumber);
        }

        public void UpdateSessionCustomerNumber(int sessionNumber, int customerNumber)
        {
            DAL.UpdateSessionCustomerNumber(sessionNumber, customerNumber);
        }

        public void UpdateSessionEmployeeNumber(int sessionNumber, int employeeNumber)
        {
            DAL.UpdateSessionEmployeeNumber(sessionNumber, employeeNumber);
        }

        public void RemoveSession(int sessionNumber)
        {
            DAL.RemoveSession(sessionNumber);
        }
    }
}
