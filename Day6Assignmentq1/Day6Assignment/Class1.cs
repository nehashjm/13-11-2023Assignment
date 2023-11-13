using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    public class Class1
    {
        
        public void Add(int whour,int wndays,int projecthandles =1,int extras=0)
        {
            int result = whour + wndays * 100 + projecthandles * 300 + extras * 2000;
            Console.WriteLine($"Result after adding{whour},{wndays},{projecthandles},{extras}"+$"=\t{result}");
        }

    }
}
