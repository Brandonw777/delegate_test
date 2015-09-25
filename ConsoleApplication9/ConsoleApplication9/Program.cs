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

            list.Add(new Func<string, string>(test2));// appending new function  Func<parameter type, return type>()
            dynamic result = list[0](); 
            
            Console.WriteLine(result);
            Console.ReadKey();
            Console.WriteLine(list[1]("b"));
            Console.ReadKey();
            Test();

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

        static void Test()
        {
            // Using lambda expression that captures parameters
            Action forLater = () => foo(3);
            // Using method group directly
            Action<object> forLaterToo = foo;
            // later
            forLater();
            forLaterToo(4);
            Console.ReadKey();
        }
        static void foo(object bar)
        {
            Console.WriteLine(bar);
        }



    }
}
