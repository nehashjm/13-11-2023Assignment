using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            string choose;
            Console.WriteLine("choose type hr admin software developer");
            choose = Console.ReadLine();
            if(choose == "hr")
            {
                obj.Add(120, 110);
            }
            else if(choose == "admin")
            {
                obj.Add(120, 110,2);
            }
            else
            {
                obj.Add(120, 110, 2,3);
            }
            Console.ReadKey();
        }
    }
}
