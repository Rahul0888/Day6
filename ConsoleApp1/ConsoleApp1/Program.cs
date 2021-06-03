using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            Console.Write("Enter Your Employee ID:");
            al.Add(Console.ReadLine());
            Console.Write("Enter Your Employee Name :");
            al.Add(Console.ReadLine());
            Console.Write("Enter Travel Date: ");
            al.Add(Console.ReadLine());
            Console.WriteLine("Enter Travel Location: ");
            al.Add(Console.ReadLine());

            Console.ReadLine();
        }
    }

}




