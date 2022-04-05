using System;
using System.Collections;

namespace CollectionEnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // boxing here
            list.Add(10);
            list.Add(12);
            list.Add(20);
            list.Add(30);

            for(int i=0;i<list.Count;i++)
                Console.WriteLine(list[i]);
            foreach(int x in list)
                Console.WriteLine(x);
            list.Insert(1, 40);

            list.Add("Ajay");
            list.Add(10.4f);
            list.Add(11);
            // It is time consuming
            // beacuse it does unboxing here 
            foreach(var x in list)
                Console.WriteLine(x);
            Stack stack = new Stack();
            stack.Push(1);












        }
    }
}
