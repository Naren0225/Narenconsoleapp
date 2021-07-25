using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narenconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD!");
            Console.WriteLine("CONSOLE APP!");


            student std = new student();


            std.name = "Naren";
            std.studentId = 1;
            std.usn = "1BSC42";

            Console.WriteLine("name: "+ std.name);
            Console.WriteLine("studentid: "+ std.studentId);
            Console.WriteLine("usn: "+ std.usn);
            Console.ReadKey();

            /*
            Console.WriteLine("using static method");
            numeric.add(10, 3);*/


            numeric numeric = new numeric();
            Console.WriteLine("using non static method");
            numeric.sum(20, 30);

        }
    }
}
