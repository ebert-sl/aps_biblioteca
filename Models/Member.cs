using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class Member
    {
        public String mName {get; set;}
        public String mAddress {get; set;}
        public int mNo {get; set;}

        public void mRequestForBk() {}
        public void mReturnForBk() {}
        public virtual void checkoutBk() {}

        public virtual ICollection<Books> Books {get; set;}
    }
}