using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnumDemo
{
    class AnonymousMethods
    {
        delegate int Del (int x, int y);
        delegate int Del1(int x);
        static void Main()
        {

            Del d = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine(d(10,20));

            // Lambda Methods are used to shorten syntax 
            // of writing anoymous methods

            // Lamda Expression
            // (input) => { output; }
            // Expression x+y ; 2*9;
            Del1 d2 = x => x % 10;
            Del d1 =  (x,  y) => x + y;
             
            Console.WriteLine(d1(10,20));

            //Del del = new Del(Add);
            //Console.WriteLine(del(10,20));
        }
        //static int Add(int x, int y)
        //{ 
        //    return x + y;
        //}
    }
}
