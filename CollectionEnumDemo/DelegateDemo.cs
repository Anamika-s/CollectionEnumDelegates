using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnumDemo
{
  
    class DelegateDemo
    {
        delegate int Del(int x, int y);

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Product(int x, int y)
        {
            return x * y;
        }
        static int Divide(int x, int y)
        {
            return x / y;
        }
        static void Main()
        {
            Del del = new Del(Add);
            Console.WriteLine(del(10,20));

            del = new Del(Subtract);
            Console.WriteLine(del(20,10));


        }
    }
}
