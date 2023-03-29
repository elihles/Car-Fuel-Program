using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter1, filter2, filter3;
            double price1, price2, price3, ans1,discount,ans3;
            Console.Write("Enter the part name?");
            filter1 = Console.ReadLine();
            Console.Write("Enter the part price?");
            price1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the part name?");
            filter2 = Console.ReadLine();
            Console.Write("Enter the part price?");
            price2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the part name?");
            filter3 = Console.ReadLine();
            Console.Write("Enter the part price?");
            price3 = Convert.ToDouble(Console.ReadLine());
            ans1=price1+ price2 + price3;
            discount = ans1 * 0.2;
            ans3 = discount + ans1;
            Console.WriteLine(" \t\t\t");
            Console.WriteLine("{0}\t\t\t{1}",filter1,price1);
            Console.WriteLine("{0}\t\t\t{1}", filter2, price2);
            Console.WriteLine("{0}\t\t\t{1}", filter3, price3);
            Console.WriteLine(" \t\t\t");
            Console.WriteLine(" \t\t\t");
            Console.WriteLine("\t\t\t{0:C2}", ans1);
            Console.WriteLine("+\t\t\t{0:C2}", discount);
            Console.WriteLine("---------------------------");
            Console.WriteLine("\t\t\t{0:C2}", ans3);

            Console.ReadLine();


        }
    }
}
