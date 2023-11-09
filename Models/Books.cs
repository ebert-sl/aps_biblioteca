using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class Books
    {
        public int Id {get; set;}
        public String bookName {get; set;}
        public String authorName {get; set;}
        public int noOfBooks {get; set;}

        public void removeFirmCatalog() {}
        public void addToCatalog() {}
    }
}