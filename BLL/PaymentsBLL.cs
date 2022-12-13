using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    [System.ComponentModel.DataObject]
    public class PaymentsBLL
    {
        private PaymentsDAL DAL = new PaymentsDAL();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddPayment(int sessionNumber, float requiredPayment, float receivedPayment)
        {
            DAL.AddPayment(new Payment
            {
                Number = DAL.GetLastNumber() + 1,
                SessionNumber = sessionNumber,
                RequiredPayment = requiredPayment,
                ReceivedPayment = receivedPayment,
                PaymentChange = receivedPayment - requiredPayment,            
                PaymentDate = DateTime.Now
            });
        }

        public List<Payment>? GetAllPayments()
        {
            return DAL.GetAllPayments();
        }

        public Payment? GetPaymentByNumber(int paymentNumber)
        {
            return DAL.GetPaymentByNumber(paymentNumber);
        }

        public Payment? GetPaymentBySession(int sessionNumber)
        {
            return DAL.GetPaymentBySession(sessionNumber);
        }

        public void UpdatePaymentSessionNumber(int paymentNumber, int newSessionNumber)
        {
            DAL.UpdatePaymentSessionNumber(paymentNumber, newSessionNumber);
        }

        public void RemovePayment(int paymentNumber)
        {
            DAL.RemovePayment(paymentNumber);
        }
    }
}
