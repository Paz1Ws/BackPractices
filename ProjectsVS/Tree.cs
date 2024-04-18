namespace ProjectsVS
{
    public class Tree
    {
        public Node root;

        public Tree(int value)
        {
            root = new Node(value);
        }
        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                AddRecursive(root, value);
            }
        }
        private void AddRecursive(Node current, int value)
        {
            if (value < current.value)
            {
                if (current.left == null)
                {
                    current.left = new Node(value);
                }
                else
                {
                    AddRecursive(current.left, value);
                }
            }
            else if (value > current.value)
            {
                if (current.right == null)
                {
                    current.right = new Node(value);
                }
                else
                {
                    AddRecursive(current.right, value);
                }
            }
        }
        public void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.right);
                Console.Write(node.value + " ");
                InOrderTraversal(node.left);
            }
        }
    }
}
