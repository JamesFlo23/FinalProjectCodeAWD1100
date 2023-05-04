using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class NonCustomerAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public int ID { get; set; }
        public Image Photo { get; set; }
        public NonCustomerAccount() { }
        public NonCustomerAccount(string firstName, string lastName, string sSN, string address, int iD, Image photo)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = sSN;
            Address = address;
            ID = iD;
            Photo = photo;
        }
    }
}
