using System;
namespace AddressBook 
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Addressbook book = new Addressbook();



            while (true)
            {
                Console.WriteLine("enter add -1 viwe-2");

                string a = Console.ReadLine();
                char check = a[0];
                switch (check)
                {
                    case '1':
                        book.takeinput();
                        break;
                    case '2':
                        book.View();
                        break;
                    default:Console.WriteLine("enter right option");
                        break;

                }
            }
        }  
    
    }


}
