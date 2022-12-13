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
    public class DiscountCard
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public LinkedList<Session> Sessions { get; set; }
    }
}
