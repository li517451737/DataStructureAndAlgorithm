using System;
using System.Collections.Generic;
using System.Text;

namespace Bintree
{
    /// <summary>
    /// 二叉查找树节点
    /// </summary>
    public class Node
    {
        /// <summary>
        /// 节点数据
        /// </summary>
        public int Data;
        /// <summary>
        /// 左节点
        /// </summary>
        public Node Left;
        /// <summary>
        /// 右节点
        /// </summary>
        public Node Right;
        /// <summary>
        /// 显示节点数据
        /// </summary>
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }
    /// <summary>
    /// 二叉查找树
    /// </summary>
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        //
        // 摘要:
        //    1.把父节点设置为当前节点，即根节点。
        //    2.如果新节点内的数据值小于当前节点内的数据值，那么把当前节点设置为当前节点的左子节点。如果新节
        //    点内的数据值大于当前节点内的数据值，那么就跳到步骤 4。
        //    3.如果当前节点的左子节点的数值为空（null），就把新节点插入在这里并且退出循环。否则，跳到 while 循
        //    环的下一次循环操作中。
        //    4.把当前节点设置为当前节点的右子节点。
        //    5.如果当前节点的右子节点的数值为空（null），就把新节点插入在这里并且退出循环。否则，跳到 while 循
        //    环的下一次循环操作中。
        //
        // 参数:
        //   i:
        //     新节点值
        /// <summary>
        /// 插入新节点
        /// </summary>
        /// <param name="i"></param>
        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    //如果新节点内的数据值小于当前节点内的数据值，那么把当前节点设置为当前节点的左子节点
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 中序遍历
        /// 通过递归的方式，分别访问每棵子树的左节点和右节点，
        /// 跟着是访问根节点的左子节点下的子树，
        /// 再接着是访问根节点的右子节点下的子树
        /// </summary>
        /// <param name="theRoot"></param>
        public void InOrder(Node theRoot)
        {
            if (theRoot != null)
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }
        /// <summary>
        /// 先序遍历，
        /// </summary>
        /// <param name="theRoot"></param>
        public void PreOrder(Node theRoot)
        {
            if (theRoot != null)
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }
        /// <summary>
        /// 后序遍历
        /// 在后序遍历中，方法首先遍历左子树，然后是右子树
        /// </summary>
        /// <param name="theRoot"></param>
        public void PostOrder(Node theRoot)
        {
            if (theRoot != null)
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }

    }
}
