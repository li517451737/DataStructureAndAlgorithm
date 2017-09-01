using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    public class Node
    {

        public int Data { get; set; }

        /// <summary>
        /// 左节点
        /// </summary>
        public Node Left { get; set; }

        /// <summary>
        /// 右节点
        /// </summary>
        public Node Right { get; set; }
    }
}
