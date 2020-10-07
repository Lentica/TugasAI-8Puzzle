using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasAI_8Puzzle
{
    class Tree
    {
        public TreeNode root
        {
            get; set;
        }
        public void ExampleTree()
        {
            squareCoords temp = new squareCoords(100, 100, 1);

            TreeNode root = new TreeNode(temp);

            TreeNode node = new TreeNode(new squareCoords(200, 200, 2));

            root.child1 = node;
            node.parent = root;

            root.child2 = new TreeNode(new squareCoords(300, 300, 3));

            root.child2.parent = root;

            root.child3 = new TreeNode(new squareCoords(300, 300, 4));

            root.child3.parent = root;

            root.child4 = new TreeNode(new squareCoords(300, 300, 5));

            root.child4.parent = root;

            root.child1.child1 = new TreeNode(new squareCoords(300, 300, 6));

            root.child1.child1.parent = root.child1;



            this.root = root;
        }

        public void exampleTreeArray()
        {
            TreeNode root = new TreeNode(new squareCoords(100, 100, 1));
            TreeNode node = new TreeNode(new squareCoords(200, 200, 2));



            root.childs[0] = node;
            root.childs[1] = new TreeNode(new squareCoords(400, 400, 3));
            root.childs[2] = new TreeNode(new squareCoords(400, 400, 8));
            root.childs[3] = new TreeNode(new squareCoords(500, 500, 11));

            root.childs[0].parent = root;
            root.childs[1].parent = root;
            root.childs[2].parent = root;
            root.childs[3].parent = root;

            root.childs[0].childs[0] = new TreeNode(new squareCoords(600, 600, 32));
            root.childs[0].childs[1] = new TreeNode(new squareCoords(700, 700, 67));

            root.childs[0].childs[0].parent = root.childs[0];
            root.childs[0].childs[0].parent = root.childs[0];

            this.root = root;
        }

        public string BfsTraverse()
        {
            string ret = "";

            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root);

            while (q.Count>0)
            {
                TreeNode temp = q.Dequeue();
                ret += temp.data.Number+"\n";
                if (temp.child1!=null)
                {
                    q.Enqueue(temp.child1);
                }
                if (temp.child2 != null)
                {
                    q.Enqueue(temp.child2);
                }
                if (temp.child3 != null)
                {
                    q.Enqueue(temp.child3);
                }
                if (temp.child4 != null)
                {
                    q.Enqueue(temp.child4);
                }
            }
            return ret;
        }

        public string bfsTraverseArray()
        {
            string ret = "";
            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root);

            while (q.Count>0)
            {
                TreeNode temp = q.Dequeue();
                ret += temp.data.Number+"";

                for (int i = 0; i < temp.childs.Length; i++)
                {
                    if (temp.childs[i]!=null)
                    {
                        q.Enqueue(temp.childs[i]);
                    }
                }
            }

            return ret;
        }

        public int getLevel()
        {
            int ret = 0;

            TreeNode temp = this.root;

            while (temp!=null)
            {
                ret++;
                temp = temp.child1;
            }
            return ret;
        }
    }
}
