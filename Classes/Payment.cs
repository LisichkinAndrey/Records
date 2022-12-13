using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Linq;
using System.Text;
using System.IO;

namespace records
{
    public class Payment
    {
        [Key]
        public int Number { get; set; }
        public float RequiredPayment { get; set; }
        public float ReceivedPayment { get; set; }
        public float PaymentChange { get; set; }

        public DateTime PaymentDate { get; set; }

        public int SessionNumber { get; set; }
        public Session Session { get; set; }
    }
}
