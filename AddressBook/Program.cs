using System;
namespace AddressBook 
{
    public class Program 
    {
        public static void Main(string[] args) 
        {
             Console.WriteLine("Welcome to Address Book");
             Addressbook book= new Addressbook();
             book.takeinput();
             book.View();
             

        }     
    
    }


}
