namespace ChapterFour
{

    public class BinaryTree<T>
    {
        internal Node<T>? root;
   
        public void PrintInOrder()
        {
            Recursive<T>.InOrderTraversal(root);
        }
      
        public void PrintPreOrder()
        {
            Iterative<T>.PreOrderTraversal(root);
        }   

        public void PrintPostOrder()
        {
            Recursive<T>.PostOrderTraversal(root);
        }
    }

    public class Traversal
    {
        public static void Run()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.root = new Node<int>(1);
            tree.root.left = new Node<int>(2);
            tree.root.right = new Node<int>(3);
            tree.root.left.left = new Node<int>(4);
            tree.root.left.right = new Node<int>(5);
            tree.root.right.right = new Node<int>(6);
           // tree.PrintInOrder();
           // tree.PrintPostOrder();
            tree.PrintPreOrder();
        }
    }

    internal class Recursive<T>
    {
        internal static void InOrderTraversal(Node<T>? subtree)
        {
            if (subtree == null)
                return;

            InOrderTraversal(subtree.left);
            Console.Write(subtree.data + " ");
            InOrderTraversal(subtree.right);
        }

        internal static void PreOrderTraversal(Node<T>? subtree)
        {
            if (subtree == null)
                return;

            Console.Write(subtree.data + " ");
            PreOrderTraversal(subtree.left);
            PreOrderTraversal(subtree.right);
        }

        internal static void PostOrderTraversal(Node<T>? subtree)
        {
            if (subtree == null)
                return;

            PostOrderTraversal(subtree.left);
            PostOrderTraversal(subtree.right);
            Console.Write(subtree.data + " ");
        }

    }

    internal class Iterative<T>
    {
        internal static void InOrderTraversal(Node<T>? root)
        {
            List<T> answer = new List<T>();
            Stack<Node<T>> s = new Stack<Node<T>>();
            if (root != null)
            {
                s.Push(root);
            }
            Node<T> cur;
            while (s.Any())
            {
                cur = s.Pop();
                answer.Add(cur.data);           
                if (cur.right != null)
                {
                    s.Push(cur.right);          
                }
                if (cur.left != null)
                {
                    s.Push(cur.left);
                }
            }
            Console.WriteLine(answer.ToString());
        }
         
        internal static void PreOrderTraversal(Node<T>? root)
        {
            List<T> answer = new List<T>();
            Stack<Node<T>> s = new Stack<Node<T>>();
            if (root != null)
            {
                s.Push(root);
            }
            Node<T> cur;
            while (s.Any())
            {
                cur = s.Pop();
                answer.Add(cur.data);
                if (cur.right != null)
                {
                    s.Push(cur.right);
                }
                if (cur.left != null)
                {
                    s.Push(cur.left);
                }
            }
            Console.WriteLine(answer.ToString());
        }

        internal static void PostOrderTraversal(Node<T>? root)
        {
            List<T> answer = new List<T>();
            Stack<Node<T>> s = new Stack<Node<T>>();
            if (root != null)
            {
                s.Push(root);
            }
            Node<T> cur;
            while (s.Any())
            {
                cur = s.Pop();
                answer.Add(cur.data);
                if (cur.right != null)
                {
                    s.Push(cur.right);
                }
                if (cur.left != null)
                {
                    s.Push(cur.left);
                }
            }
            Console.WriteLine(answer.ToString());
        }

    }
}