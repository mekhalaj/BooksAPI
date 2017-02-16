using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementBusinessObject
{
    public class Book
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Edition { get; set; }
        public string Format { get; set; }
        public int Pages { get; set; }
    }
}
