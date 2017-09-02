using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    public class Node
    {
        public object Element;
        public Node Link;
        public Node()
        {
            Element = null;
            Link = null;
        }

        public Node(object element)
        {
            this.Element = element;
            Link = null;
        }
    }
    /// <summary>
    /// 单向链表实例
    /// </summary>
    public class LinkedList
    {
        protected Node header;

        public LinkedList()
        {
            header = new Node("header");
        }
        /// <summary>
        /// 把新节点的 Link 字段设置为“指定”节点的 Link 字段，然后把“指定”节点的 Link 字段设置为指向新节点
        /// </summary>
        /// <param name="newItem">新节点</param>
        /// <param name="after">指定节点</param>
        public void Insert(object newItem, object after)
        {
            Node current = new Node();
            Node newNode = new Node(newItem);
            current = Find(after);
            newNode.Link = current.Link;
            current.Link = newNode;
        }

        /// <summary>
        /// 移除指定节点
        /// </summary>
        /// <param name="n"></param>
        public void Remove(object n)
        {
            Node p = FindPrevious(n); // 查询结果如果存在 p.Link = Node(n);
            if (p.Link != null)
            {
                p.Link = p.Link.Link;//设置p的下一个元素等于n的下一元素，即链表从n的上一个元素，链接到n的下一个元素，中间跳过n;
            }
        }
        /// <summary>
        /// 遍历链表，并打印链表中的每个元素
        /// </summary>
        public void PrintList()
        {
            Node current = new Node();
            current = header;
            while (current.Link != null)
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }


        /// <summary>
        /// 搜索每个节点的 Element 字段，直到找到匹配为止(遍历链表)
        /// 首先，实例化一个 Node 对象 current，并且把它设置为头节点。然后查看
        ///   节点内 Element 字段的数值是否等于要查找的数值。如果不是，就移动到下一个节点去，其方法是把此节点赋值到
        ///   current 的 Link 字段内作为 current 的新数值。
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private Node Find(object item)
        {
            Node current = new Node();
            current = header;
            while (current.Element != item)
            {
                current = current.Link;
            }
            return current;
        }
        /// <summary>
        /// 向后遍历链表，然后停在每个节点处来查看下一个节点的 Element 字段是否存有指定的对象
        /// </summary>
        /// <param name="n">指定节点对象</param>
        /// <returns>指定元素的上一个节点</returns>
        private Node FindPrevious(object n)
        {
            Node current = header;
            while (!(current.Link != null && current.Link.Element != n))
                current = current.Link;
            return current;
        }
    }
}
