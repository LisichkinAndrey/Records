using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace records
{
    public class PaymentsDAL
    {
        ApplicationContext db = new ApplicationContext();

        public void AddPayment(Payment payment)
        {
            db.Payments.Add(payment);
        }

        public int GetLastNumber()
        {
            int? id = db.Payments.Max(r => r.Number);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<Payment>? GetAllPayments()
        {
            List<Payment>? payments = db.Payments.ToList();
            return payments;
        }

        public Payment? GetPaymentByNumber(int paymentNumber)
        {
            Payment? payment = (from r in db.Payments where r.Number == paymentNumber select r).FirstOrDefault();
            return payment;
        }

        public Payment? GetPaymentBySession(int sessionNumber)
        {
            Payment? payment = (from r in db.Payments where r.SessionNumber == sessionNumber select r).FirstOrDefault();
            return payment;
        }

        public void UpdatePaymentSessionNumber(int paymentNumber, int newSessionNumber)
        {
            Payment? payment = (from r in db.Payments where r.SessionNumber == newSessionNumber select r).FirstOrDefault();
            if (payment != null)
            {
                payment.SessionNumber = newSessionNumber;
                db.SaveChanges();
            }
        }

        public void RemovePayment(int paymentNumber)
        {
            Payment? payment = (from r in db.Payments where r.Number == paymentNumber select r).FirstOrDefault();
            if (payment != null)
            {
                db.Payments.Remove(payment);
            }
        }
    }
}
