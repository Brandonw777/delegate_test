using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var list = new List<dynamic>{ new Func<int> (test1)}; //init functionlist and add a function


            Console.WriteLine("Words...");
            Console.ReadKey();
            list.Add(new Func<string, string>(test2));
            dynamic result = list[0](); // like X(1, 2)
            
            Console.WriteLine(result);
            Console.ReadKey();
            Console.WriteLine(list[1]("b"));
            Console.ReadKey();

        }


        static int test1()
        {
            Console.WriteLine("HI!!!");
            return 1;
        }
        static string test2(string x)
        {
            return x;
        }
        

    }
}
