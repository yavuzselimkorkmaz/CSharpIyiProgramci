using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1,FirstName="Yavuz",LastName="Korkmaz",City="İstanbul" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2,"Selin","Korkmaz","Ankara");

            Console.WriteLine(customer2.FirstName);



            Method(7, "mehmet", "demir", "diyarbakır");
            Console.ReadLine();
            
        }

        static void Method(int id,string firstName,string lastName ,string city)
        {

        }

    }



    class Customer
    {
        public Customer(int id,string firstName,string lastName,string city)
        {
           Id = id;
           FirstName = firstName;  
           LastName = lastName;    
           City = city;    
        }

        //default constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı Blok Çalıştı");
        }



        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
