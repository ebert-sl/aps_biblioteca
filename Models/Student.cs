using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class Student : Member
    {
        public String sName {get; set;}
        public String studentColl {get; set;}

        public override void checkoutBk(){}
        public void returnBk(){}
    }
}