using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    /// <summary>
    /// 循环链表实例
    /// 循环链表是一种尾节点返回指向首节点（它可能是头节点）的链表
    /// </summary>
    public class CycleLinkedList
    {
        protected CycleNode current;

        protected CycleNode header;
        private int count;

        public CycleLinkedList()
        {
            count = 0;
            header = new CycleNode("header");
            header.Link = header;
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return header.Link == null;
        }
        /// <summary>
        /// 清空链表
        /// </summary>
        public void MakeEmpty()
        {
            header.Link = null;
        }

        public void PrintList()
        {
            CycleNode current = new CycleNode();
            current = header;
            while (current.Link.Element.ToString() != "header")
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }
        /// <summary>
        /// 查找指定元素的前一个节点
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public CycleNode FindPrevious(object n)
        {
            CycleNode current = header;
            while (current.Link != null && current.Link.Element != n)
            {
                current = current.Link;
            }
            return current;
        }
        /// <summary>
        /// 查找指定元素所在节点
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public CycleNode Find(object n)
        {
            CycleNode current = new CycleNode();
            current = header.Link;
            while (current.Element != n)
            {
                current = current.Link;
            }
            return current;
        }
        /// <summary>
        /// 移除指定元素的节点
        /// </summary>
        /// <param name="n"></param>
        public void Remove(object n)
        {
            CycleNode current = FindPrevious(n);
            if (current.Link != null)
                current.Link = current.Link.Link;
            count--;
        }
        /// <summary>
        /// 在指定节点后，查询新的元素节点
        /// </summary>
        /// <param name="n1">新节点元素</param>
        /// <param name="n2">指定节点元素</param>
        public void Insert(object n1, object n2)
        {
            CycleNode current = new CycleNode();
            CycleNode newNode = new CycleNode(n1);
            current = Find(n2);
            newNode.Link = current.Link;
            current.Link = newNode;
            count++;
        }
        /// <summary>
        /// 插入第一个元素
        /// </summary>
        /// <param name="n"></param>
        public void InsertFirst(object n)
        {
            CycleNode current = new CycleNode(n);
            current.Link = header;
            header.Link = current;
            count++;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public CycleNode Move(int n)
        {
            CycleNode current = header.Link;
            CycleNode temp;
            for (int i = 0; i <= n; i++)
            {
                current = current.Link; 
            }
            if (current.Element.ToString() == "header")
            {
                current = current.Link;
            } 
            temp = current;
            return temp;
        }

    }
    /// <summary>
    /// 循环链表节点
    /// </summary>
    public class CycleNode
    {
        public object Element;

        public CycleNode Link;

        public CycleNode()
        {
            Element = null;
            Link = null;
        }

        public CycleNode(object element)
        {
            Element = element;
            Link = null;
        }
    }
}
