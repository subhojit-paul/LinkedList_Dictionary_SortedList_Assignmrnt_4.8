using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
            lList.AddFirst("the");
            foreach(var v in lList)
            {
                Console.Write(" "+v);
            }
            Console.WriteLine("\n");
            LinkedListNode<string> cu = lList.Find("fox");
            lList.AddBefore(cu, "brown");
            foreach (var v in lList)
            {
               
                Console.Write(" " + v);
            }

            Console.WriteLine("\n");
            LinkedListNode<string> cu1 = lList.Find("fox");
            lList.AddAfter(cu1, "jumps");

            foreach (var v in lList)
            {
                Console.Write(" " + v);
            }
            Console.WriteLine("\n");
            LinkedListNode<string> cu2 = lList.FindLast("the");
            lList.AddBefore(cu2, "over");
            foreach (var v in lList)
            {
                Console.Write(" " + v);
            }

            Console.WriteLine("\n");
            LinkedListNode<string> cu3 = lList.Find("lazy");
            lList.AddAfter(cu3, "fox");
            foreach (var v in lList)
            {
                Console.Write(" " + v);
            }


            Console.Read();

        }
    }
}
