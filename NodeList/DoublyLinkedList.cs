using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    /// <summary>
    /// 双向链表实例
    /// </summary>
    public class DoubleNode
    {
        /// <summary>
        /// 当前节点元素
        /// </summary>
        public object Element;
        /// <summary>
        /// 后一个节点
        /// </summary>
        public DoubleNode Flink;

        /// <summary>
        /// 前一个节点
        /// </summary>
        public DoubleNode Blink;

        public DoubleNode()
        {
            Element = null;
            Flink = null;
            Blink = null;
        }

        public DoubleNode(object element)
        {
            Element = element;
            Flink = null;
            Blink = null;
        }
    }

    public class DoubleLinkedList
    {
        public DoubleNode header;

        public DoubleLinkedList()
        {
            header = new DoubleNode("header");
        }
        /// <summary>
        /// 把新节点的 Link 字段设置为“指定”节点的 Link 字段，然后把“指定”节点的 Link 字段设置为指向新节点
        /// </summary>
        /// <param name="newItem">新节点</param>
        /// <param name="after">指定节点</param>
        public void Insert(object newItem, object after)
        {
            DoubleNode current = new DoubleNode();
            DoubleNode newNode = new DoubleNode(newItem);
            current = Find(after);
            newNode.Flink = current.Flink;
            newNode.Blink = current;
            current.Flink = newNode;
        }
        /*
         找到表内要删除的节点，然后把此节
        点的向后链接属性设为指向要删除节点向前链接所指向的节点。然后需要对删除节点所指向链接的后链接进行重定
        向操作，把它指向删除节点之前的节点
             */
        /// <summary>
        /// 移除指定元素
        /// </summary>
        /// <param name="n"></param>
        public void Remove(object n)
        {
            DoubleNode p = Find(n);
            if (p.Flink != null)
            {
                p.Blink.Flink = p.Flink;
                p.Flink.Blink = p.Blink;
                p.Flink = null;
                p.Blink = null;
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
        private DoubleNode Find(object item)
        {
            DoubleNode current = new DoubleNode();
            current = header;
            while (current.Element != item)
            {
                current = current.Flink;
            }
            return current;
        }
    }
}
