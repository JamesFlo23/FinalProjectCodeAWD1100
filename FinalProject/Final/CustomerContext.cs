using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class CustomerContext: DbContext
    {
        DbSet<CustomerAccount> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TempProducts;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAccount>().HasData(
             new CustomerAccount { FirstName = "Patrick", LastName="Star", SSN="123-45-6789",ID=112233, Address= "178 Bikini Bottom Rd", Balance= 600.00f, AccountNumber= 101000 },
             new CustomerAccount { FirstName="Spongebob",LastName="Squarepants",SSN="465-78-7878",ID=223344, Address = "182 Bikini Bottom Rd", Balance = 78000.00f, AccountNumber = 101001 },
             new CustomerAccount { FirstName="Sandy", LastName="Cheeks", SSN="111-11-1118", ID=334455, Address = "126 Conch Street", Balance = 500000.00f, AccountNumber = 101002 },
             new CustomerAccount { FirstName="Eugene",LastName= "Krabs",SSN= "345-77-6658",ID= 445566, Address = "3541 Anchor Way", Balance = 1000000.00f, AccountNumber = 101003 }
            );
            

        }
    }
    
}
