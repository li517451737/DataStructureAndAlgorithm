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
        //protected CycleNode current;

        protected CycleNode header;
        //private int count;

        public CycleLinkedList()
        {
            //count = 0;
            header = new CycleNode("header");
            //header.Link = header;
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
        /**
        /// <summary>
        /// 遍历链表
        /// </summary>
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
         */

        public void ShowList()
        {
            CycleNode current = header.Link;
            while (current.Link!= null)
            {
                Console.WriteLine(current.Element);
                current = current.Link;
            }
        }
        ///// <summary>
        ///// 查找指定元素的前一个节点
        ///// </summary>
        ///// <param name="n"></param>
        ///// <returns></returns>
        //public CycleNode FindPrevious(object n)
        //{
        //    CycleNode current = header;
        //    while (current.Link != null && current.Link.Element != n)
        //    {
        //        current = current.Link;
        //    }
        //    return current;
        //}
        /// <summary>
        /// 查找指定元素所在节点
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public CycleNode Find(object n)
        //{
        //    CycleNode current = new CycleNode();
        //    current = header.Link;
        //    while (current.Element != n)
        //    {
        //        current = current.Link;
        //    }
        //    return current;
        //}
        ///// <summary>
        ///// 移除指定元素的节点
        ///// </summary>
        ///// <param name="n"></param>
        //public void Remove(object n)
        //{
        //    CycleNode current = FindPrevious(n);
        //    if (current.Link != null)
        //        current.Link = current.Link.Link;
        //    count--;
        //}
        ///// <summary>
        ///// 在指定节点后，查询新的元素节点
        ///// </summary>
        ///// <param name="n1">新节点元素</param>
        ///// <param name="n2">指定节点元素</param>
        //public void Insert(object n1, object n2)
        //{
        //    CycleNode current = new CycleNode();
        //    CycleNode newNode = new CycleNode(n1);
        //    current = Find(n2);
        //    newNode.Link = current.Link;
        //    current.Link = newNode;
        //    count++;
        //}
        ///// <summary>
        ///// 插入第一个元素
        ///// </summary>
        ///// <param name="n"></param>
        //public void InsertFirst(object n)
        //{
        //    CycleNode current = new CycleNode(n);
        //    current.Link = header;
        //    header.Link = current;
        //    count++;
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="n"></param>
        ///// <returns></returns>
        //public CycleNode Move(int n)
        //{
        //    CycleNode current = header.Link;
        //    CycleNode temp;
        //    for (int i = 0; i <= n; i++)
        //    {
        //        current = current.Link;
        //    }
        //    if (current.Element.ToString() == "header")
        //    {
        //        current = current.Link;
        //    }
        //    temp = current;
        //    return temp;
        //}
       
        /// <summary>
        /// 获取第一个元素
        /// </summary>
        /// <returns></returns>
        public CycleNode GetFirst()
        {
            return header;
        }

    }
    /// <summary>
    /// 迭代器
    /// </summary>
    public class Listlter
    {
        /// <summary>
        /// 当前节点
        /// </summary>
        private CycleNode current;
        /// <summary>
        /// 上一个节点
        /// </summary>
        private CycleNode previous;
        /// <summary>
        /// 链表实例
        /// </summary>
        CycleLinkedList theList;
        public Listlter(CycleLinkedList list)
        {
            theList = list;
            current = list.GetFirst();
            previous = null;
        }

        /// <summary>
        /// 在链表中从一个节点移动到下一个节点
        /// </summary>
        public void NextLink()
        {
            previous = current;
            current = current.Link;
        }
        /// <summary>
        /// 返回由迭代器指向的节点
        /// </summary>
        /// <returns></returns>
        public CycleNode GetCurrent()
        {
            return current;
        }

        /// <summary>
        /// 在当前节点钱插入指定元素
        /// </summary>
        /// <param name="element"></param>
        public void InsertBefore(object element)
        {
            CycleNode newNode = new CycleNode(element);
            if (current.Element.ToString() == "header")
            {
                throw new InsertBeforeHeaderException();
            }
            else
            {
                newNode.Link =previous.Link;
                previous.Link = newNode;
                current = newNode;
            }
        }
        /// <summary>
        /// 在当前节点后插入指定元素
        /// </summary>
        /// <param name="element"></param>
        public void InsertAfter(object element)
        {
            CycleNode newNodel = new CycleNode(element);
            newNodel.Link = current.Link;
            current.Link = newNodel;
            NextLink();
        }
        /// <summary>
        /// 移除当前节点，将前节点的Link字段设置为当前节点的Link字段
        /// </summary>
        public void Remove()
        {
            previous.Link = current.Link;
        }
        /// <summary>
        /// 重新设置为头节点
        /// </summary>
        public void Rest()
        {
            current = theList.GetFirst();
            previous = null;
        }
        /// <summary>
        /// 检查是否在表尾
        /// </summary>
        /// <returns></returns>
        public bool AtEnd()
        {
            return current.Link == null;
        }
        /// <summary>
        /// 约瑟夫环
        /// </summary>
        /// <param name="i"></param>
        /// <param name="m"></param>
        public void Yueseful(int i,int m)
        {
            CycleNode f = theList.GetFirst();
            CycleNode r = f;
            for (; i> 0; i--)
            {
                r = f;
                f = f.Link;
            }
            while (r.Link != r)
            {
                for (int j = 0; j < m; j++)
                {
                    r = f;
                    f = f.Link;
                }
                Console.Write(f.Element.ToString() + " ");
                f = f.Link;
                r.Link = f;
            }
            Console.WriteLine(r.Element.ToString());
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
    public class InsertBeforeHeaderException : Exception
    {
        public InsertBeforeHeaderException() : base("不能再头节点插入！")
        {

        }
    }
}
