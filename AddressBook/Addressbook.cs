using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public  class Addressbook
    {
      List <Contact>Listcontact;
      public  Addressbook()
      { 
        Listcontact= new List<Contact>();
       
      }

        public Contact takeinput( ) 
        { 
           Contact contact= new Contact();

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
            Listcontact.Add(contact);
            return contact;
        }
        public void View( )
        {
            if (Listcontact.Count <=0)
            {
                Console.WriteLine("book is empty");
            }
            else
            {
                foreach (var contacts in Listcontact)
                {
                        Console.WriteLine
                        (
                        @$"
                         Name   :{contacts.FirstName} {contacts.LastName}
                         Address:{contacts.Address}
                         ZipCod :{contacts.zipcode}
                         City   :{contacts.city} 
                         State  :{contacts.state} 
                         Country:{contacts.country}
                         Phone  :{contacts.phone}
                         Email  :{contacts.email}

                        ");
                }  
            }
        }




    }
}
