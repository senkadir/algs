namespace Algorithms
{
    public class BinaryTree
    {
        private Node _root;

        public BinaryTree()
        {
        }

        public Node Root
        {
            get
            {
                return _root;
            }
        }

        public void Insert(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);

                return;
            }

            Insert(_root, new Node(value));
        }

        private void Insert(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Value < root.Value)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    Insert(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    Insert(root.Right, newNode);
                }
            }
        }
    }

    public class Node
    {
        public Node Left { get; set; }

        public Node Right { get; set; }

        public int Value { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
