using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class Alert
    {   
        public int Id {get; set;}
        public DateOnly issueDate {get; set;}
        public String bookName {get; set;}
        public DateOnly returnDate {get; set;}
        public int fine {get; set;}

        public void fineCall() {}
        public void viewAlert() {}
        public void sendToLibrarian() {}
        public void deleteAlertByNo() {}
    }
}