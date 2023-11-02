using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class FacultyMember : Member
    {
        public String fName {get; set;}
        public String facultyColl {get; set;}

        public override void checkoutBk(){}
    }
}