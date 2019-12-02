using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIcomputers.Models
{
    public class Borrowers
    {
        public int ID { get; set; }
        public string Surename { get; set; }
        public  string Firstname { get; set; }
        public string  DOB { get; set; }

        public IEnumerable<Books> books { get; set; }
    }
}