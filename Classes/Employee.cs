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
    public class Employee
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNumber { get; set; }
        public string Position { get; set; }
        public int experience { get; set; }
        public DateTime BirthDate { get; set; }

        public LinkedList<Session> Sessions { get; set; }
    }
}
