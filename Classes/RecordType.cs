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
    public class RecordType
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float PaymentPerHour { get; set; }

        public LinkedList<Session> Sessions { get; set; }
    }
}
