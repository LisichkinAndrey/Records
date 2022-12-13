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
    [Route("sessions")]
    [ApiExplorerSettings(GroupName = "sessions")]
    public class SessionsController : ControllerBase
    {

        SessionsBLL BLL = new SessionsBLL();

        [HttpPut]
        [Route("add")]
        public void AddSession(string name, DateTime duration, int customerNumber, int employeeNumber, int recordTypeNumber, int discountCardNumber, int paymentNumber)
        {
            BLL.AddSession(name, duration, customerNumber, employeeNumber, recordTypeNumber, discountCardNumber, paymentNumber);
        }

        [HttpGet]
        [Route("get_all")]
        public List<Session>? GetAllSessions()
        {
            return BLL.GetAllSessions();
        }

        [HttpGet]
        [Route("get_by_num")]
        public Session? GetSessionByNumber(int sessionNumber)
        {
            return BLL.GetSessionByNumber(sessionNumber);
        }

        [HttpGet]
        [Route("get_by_customer")]
        public List<Session>? GetSessionsByCustomerNumber(int sessionNumber)
        {
            return BLL.GetSessionsByCustomerNumber(sessionNumber);
        }

        [HttpGet]
        [Route("get_by_employee")]
        public List<Session>? GetSessionsByEmployeeNumber(int sessionNumber)
        {
            return BLL.GetSessionsByEmployeeNumber(sessionNumber);
        }

        [HttpPatch]
        [Route("patch_customer")]
        public void UpdateSessionCustomerNumber(int sessionNumber, int customerNumber)
        {
            BLL.UpdateSessionCustomerNumber(sessionNumber, customerNumber);
        }

        [HttpPatch]
        [Route("patch_employee")]
        public void UpdateSessionEmployeeNumber(int sessionNumber, int customerNumber)
        {
            BLL.UpdateSessionEmployeeNumber(sessionNumber, customerNumber);
        }

        [HttpDelete]
        [Route("delete_by_num")]
        public void RemoveSession(int sessionNumber)
        {
            BLL.RemoveSession(sessionNumber);
        }

    }
}
