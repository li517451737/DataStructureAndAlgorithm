using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    class Program
    {
        static void Main(string[] args)
        {
            CycleLinkedList MyList = new CycleLinkedList();
            Listlter iter = new Listlter(MyList);
            string choice, value;
            iter.InsertAfter("David");
            iter.InsertAfter("Mike");
            iter.InsertAfter("Raymond");
            iter.InsertAfter("Bernica");
            iter.InsertAfter("Jennifer");
            iter.InsertBefore("Donnie");
            iter.InsertAfter("Michael");
            iter.InsertBefore("Terrill");
            iter.InsertBefore("Mayo");
            iter.InsertBefore("Clayton");
            while (true)
            {
                Console.WriteLine("(n) Move to next node");
                Console.WriteLine("(g) Get value in current node");
                Console.WriteLine("(r) Reset iterator");
                Console.WriteLine("(s) Show complete list");
                Console.WriteLine("(a) Insert after");
                Console.WriteLine("(b) Insert before");
                Console.WriteLine("(c) Clear the screen");
                Console.WriteLine("(x) Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();
                choice = choice.ToLower();
                char[] onechar = choice.ToCharArray();
                switch (onechar[0])
                {
                    case 'n':
                        if (!MyList.IsEmpty() && !iter.AtEnd())
                        {
                            iter.NextLink();
                        }
                        else
                        {
                            Console.WriteLine("无法移动到下一个节点");
                        }
                        break;
                    case 'g':
                        if (!MyList.IsEmpty())
                        {
                            Console.WriteLine("当前元素为：" + iter.GetCurrent().Element);
                        }
                        else
                        {
                            Console.WriteLine("链表为空");
                        }
                        break;
                    case 'r':
                        iter.Rest();
                        break;
                    case 's':
                        MyList.ShowList();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
