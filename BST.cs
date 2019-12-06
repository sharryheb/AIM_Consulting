using System;

namespace BinaryTree
{
    class Node
    {
        public Node(int input)
        {
            data = input;
        }
        public int data { set; get; }
        public Node left { set; get; }
        public Node right { set; get; }
    }

    class Tree
    {
        public Node TreeRoot { set; get; }
        public void Insert(int input)
        {
            Insert(input, TreeRoot);
        }

        private Node Insert(int input, Node root)
        {
            if (root == null)
            {
                root = new Node(input);
            }
            else if (input < root.data)
            {
                root.left = Insert(input, root.left);
            }
            else
            {
                root.right = Insert(input, root.right);
            }

            if (TreeRoot == null)
                TreeRoot = root;

            return root;
        }

        public int Depth()
        {
            return Depth(TreeRoot);
        }
        private int Depth(Node root)
        {
            if (root == null) return 0;
            else
            {
                int ldepth = Depth(root.left);
                int rdepth = Depth(root.right);

                if (ldepth > rdepth)
                    return (ldepth + 1);
                else
                    return (rdepth + 1);
            }
        }
    }
}
