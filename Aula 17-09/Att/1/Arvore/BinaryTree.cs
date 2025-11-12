using System;

namespace Trees
{
    public class BinaryTree
    {
        public Node? Root { get; private set; }

        public BinaryTree()
        {

            Root = null;

        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (Root == null)
            {
                Root = newNode;
                Console.WriteLine($"\nInserido: {value} (Raiz)");
                return;
            }

            Node currentNode = Root;
            while (true)
            {
                if (value < currentNode.Value)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        Console.WriteLine($"Inserido: {value}");
                        break;
                    }
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        Console.WriteLine($"Inserido: {value}");
                        break;
                    }
                    currentNode = currentNode.Right;
                }
            }
        }

        public Node? Search(int value)
        {
            Node? currentNode = Root;

            while (currentNode != null)
            {
                if (value == currentNode.Value)
                {
                    return currentNode;
                }
                else if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }
            return null; // O valor não foi encontrado
        }

        public void PrintTree()
        {
            Console.WriteLine("\nConteúdo da Árvore (percurso In-Order):");
            PrintInOrder(Root);
            Console.WriteLine();
        }

        private void PrintInOrder(Node? node)
        {
            if (node == null)
                return;

            PrintInOrder(node.Left);
            Console.Write($"{node.Value} ");
            PrintInOrder(node.Right);
        }
    }
}
        