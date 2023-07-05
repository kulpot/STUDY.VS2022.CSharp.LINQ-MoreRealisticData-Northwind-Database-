using LINQ_MoreRealisticData_Northwind_Database_;
using System;
using System.Linq;

//ref link:https://www.youtube.com/watch?v=_TasFjNcmUg&list=PL90AF0EFFEF782D27&index=16
// LINQ(Language Integrated Query) - EntityFramework - Northwind DB

static class MainClass
{
    static void Main()
    {
        IEnumerable<Customer> customers = DB.Customers;
        foreach(Customer c in customers.Take(5))
        {
            Console.WriteLine(c.ContactName);
            Console.WriteLine(c.CompanyName);
            Console.WriteLine(c.Country);
            Console.WriteLine();
        }
    }
}