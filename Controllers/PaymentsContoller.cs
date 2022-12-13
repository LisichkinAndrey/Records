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
    [Route("payments")]
    [ApiExplorerSettings(GroupName = "payments")]
    public class PaymentsController : ControllerBase
    {

        PaymentsBLL BLL = new PaymentsBLL();

        [HttpPut]
        [Route("add")]
        public void AddPayment(int sessionNumber, float requiredPayment, float receivedPayment)
        {
            BLL.AddPayment(sessionNumber, requiredPayment, receivedPayment);
        }

        [HttpGet]
        [Route("get_all")]
        public List<Payment>? GetAllPayments()
        {
            return BLL.GetAllPayments();
        }

        [HttpGet]
        [Route("get_by_num")]
        public Payment? GetPaymentByNumber(int paymentNumber)
        {
            return BLL.GetPaymentByNumber(paymentNumber);
        }

        [HttpGet]
        [Route("get_by_name")]
        public Payment? GetPaymentsBySession(int sessionNumber)
        {
            return BLL.GetPaymentBySession(sessionNumber);
        }

        [HttpPatch]
        [Route("patch_name")]
        public void UpdatePaymentSessionNumber(int paymentNumber, int newSessionNumber)
        {
            BLL.UpdatePaymentSessionNumber(paymentNumber, newSessionNumber);
        }

        [HttpDelete]
        [Route("delete_by_num")]
        public void RemovePayment(int partNumber)
        {
            BLL.RemovePayment(partNumber);
        }

    }
}
