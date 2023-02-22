using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public  class Addressbook
    {
        Contact contact;
      public  Addressbook()
      { 
        contact= new Contact();
        
      }

        public void takeinput( ) 
        {
            Console.WriteLine("Enter your first Name ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("enter your address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("enter your phone number");
            contact.phone= Console.ReadLine();
            Console.WriteLine("enter your state name");
            contact.state = Console.ReadLine();
            Console.WriteLine("enter your zip code ");
            contact.zipcode = Console.ReadLine();
            Console.WriteLine("enter your city name");
            contact.city = Console.ReadLine();
            Console.WriteLine("enter your email");
            contact.email = Console.ReadLine();
            Console.WriteLine("enter your country");
            contact.country = Console.ReadLine();
        }
        public void View( )
        {
          Console.WriteLine(contact.ToString());
        
        }




    }
}
