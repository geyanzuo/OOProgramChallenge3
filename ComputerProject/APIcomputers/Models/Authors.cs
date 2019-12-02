using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIcomputers.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Surename { get; set; }

        public IEnumerable<Books> books { get; set; }
    }
}