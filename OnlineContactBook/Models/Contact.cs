using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineContactBook.Models
{
    public class Contact
    {
        public string Photo { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
    }
}