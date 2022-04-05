using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnumDemo
{
    class GenericCollections
    {
        static void Main()
        {
            //System.Collections.Generic;
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            foreach(int x in list)
                Console.WriteLine(x);

            Stack<string> stack = new Stack<string>();
            stack.Push("Ajay");
            stack.Push("Ajay");
            foreach (string x in stack)
                Console.WriteLine(x);


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);

            Dictionary<string, int> result = new Dictionary<string, int>();
            result["Ajay"] = 90;
            result["Deepak"] = 90;
            foreach(string key in result.Keys)
                Console.WriteLine($"{key} : {result[key]}");

        }
    }
}
