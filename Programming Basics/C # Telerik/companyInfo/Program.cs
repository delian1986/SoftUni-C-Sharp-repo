using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.Write("Company name:");
            var name = Console.ReadLine();
            //Console.Write("Compaly address:");
            var address = Console.ReadLine();
            //Console.Write("Phone number:");
            var phone = Console.ReadLine();
            ///Console.Write("Fax number:");
            var fax = Console.ReadLine();
            ///Console.Write("Web Site:");
            var site = Console.ReadLine();
            //Console.Write("Manager first name:");
            var firstName = Console.ReadLine();
            ///Console.Write("Manager last name:");
            var lastName = Console.ReadLine();
            //Console.Write("Manager age:");
            var manAge = Console.ReadLine();
            //Console.Write("Manager phone:");
            var manPhone = Console.ReadLine();

            if (fax=="")
            {
                fax="(no fax)";
            }

            Console.WriteLine(name);
            //Console.WriteLine();
            //Console.WriteLine();
            Console.WriteLine("Address: "+address);
            Console.WriteLine("Tel. "+phone);
            Console.WriteLine("Fax: " +fax);
            Console.WriteLine("Web site: "+site);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName,lastName, manAge, manPhone);
        }
    }
}
