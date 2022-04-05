using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnumDemo
{
    enum Choice : byte { Add=200, Subtract, Multiply, Divide };
    class EnumDemo
    {
        static void Main()
        {
            int num1, num2, ch;

            Console.WriteLine("Enter No 1" );
            num1 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter No 2");
            num2 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter choice");
            ch = Byte.Parse(Console.ReadLine());
            switch(ch)
            {
                case (int)Choice.Add: Console.WriteLine(num1 + num2); break;
                //case 1: Console.WriteLine(num1 + num2); break;
                case (int)Choice.Subtract: Console.WriteLine(num1 - num2); break;


                //case 2: Console.WriteLine(num1 - num2); break;
                case (int)Choice.Multiply:  Console.WriteLine(num1 * num2); break;

                //case 3: Console.WriteLine(num1 * num2); break;
                case (int)Choice.Divide:  Console.WriteLine(num1 / num2); break;

                //case 4: Console.WriteLine(num1 / num2); break;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }
}
