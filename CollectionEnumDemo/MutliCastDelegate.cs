using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnumDemo
{

    class MutliCastDelegate
    {
        delegate void Del(int x, int y);

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Product(int x, int y)
        {
            Console.WriteLine(x *  y);
        }
        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            Del del = new Del(Add);
            del += new Del(Subtract);
            del += new Del(Product);
            del(10, 10);

            del -= new Del(Add);

              

        }
    }
}
