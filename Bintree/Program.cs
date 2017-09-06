using System;

namespace Bintree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree nums = new BinarySearchTree();
            nums.Insert(23);
            nums.Insert(45);
            nums.Insert(16);
            nums.Insert(37);
            nums.Insert(3);
            nums.Insert(99);
            nums.Insert(22);
            Console.WriteLine("中序遍历结果: ");
            nums.InOrder(nums.root);
            Console.WriteLine("先序遍历结果: ");
            nums.PreOrder(nums.root);
            Console.WriteLine("后序遍历结果: ");
            nums.PostOrder(nums.root);
            Console.ReadKey();
        }
    }
}
