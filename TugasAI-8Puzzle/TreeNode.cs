using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasAI_8Puzzle
{
    class TreeNode
    {
        public squareCoords data { get; set; }
        public TreeNode child1 { get; set; }
        public TreeNode child2 { get; set; }
        public TreeNode child3 { get; set; }
        public TreeNode child4 { get; set; }

        public TreeNode[] childs { get; set; }

        public TreeNode parent { get; set; }

        public TreeNode(squareCoords data)
        {
            this.data = data;
            childs = new TreeNode[4];
        }

        public int level
        {
            get
            {
                int ret = 0;
                TreeNode temp = parent;

                while (temp!=null)
                {
                    ret++;
                    temp = temp.parent;
                }

                return ret;
            }
        }
    }
}
