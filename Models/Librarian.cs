using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class Librarian
    {
        public int Id {get; set;}
        public String lName {get; set;}
        public String lAddress {get; set;}
        public int mobileNo {get; set;}

        public void updateInfo() {}
        public void issueBooks() {}
        public void memberInfo() {}
        public void searchBook() {}
        public void returnBook() {}

        public virtual ICollection<Books> Books {get; set;}
        public virtual ICollection<Member> Members {get; set;}
    }
}