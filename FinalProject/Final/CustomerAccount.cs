using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class CustomerAccount
    {
        public CustomerAccount() { }
        public CustomerAccount(string firstName, string lastName, string sSN, string address, int iD, int accountNumber, Image photo, float balance, DateOnly dateOpened)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = sSN;
            Address = address;
            ID = iD;
            AccountNumber = accountNumber;
            Photo = photo;
            Balance = balance;
            DateOpened = dateOpened;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public int ID { get; set; }
        public int AccountNumber { get; set; }
        public float Balance { get; set; }
        [NotMapped]
        public Image Photo { get; set; }
        [NotMapped]
        public DateOnly DateOpened { get; set; }


    }
}
