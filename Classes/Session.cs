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
    public class Session
    {
        [Key]
        public int Number { get; set; }
        public DateTime SessionDateTime { get; set; }
        public DateTime Duration { get; set; }

        public int CustomerNumber { get; set; }
        Customer Customer { get; set; }

        public int EmployeeNumber { get; set; }
        Employee Employee { get; set; }

        public int RecordTypeNumber { get; set; }
        RecordType RecordType { get; set; }

        public int DiscountCardNumber { get; set; }
        DiscountCard DiscountCard { get; set; }

        public int PaymentNumber { get; set; }
        Payment Payment { get; set; }

    }
}
