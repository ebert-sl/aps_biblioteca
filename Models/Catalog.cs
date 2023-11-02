using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class Catalog
    {
        public ICollection<Books> books;

        public String authorName {get; set;}
        public int noOfCopies {get; set;}

        public Catalog(ICollection<Books> _books)
        {
            books = _books;
        }

        public void updateInfo(){}
    }
}