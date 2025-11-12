using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree myTree = new BinaryTree();
            string? input;

            Console.WriteLine("--- Criador de Árvore de Busca Binária ---");
            Console.WriteLine("Digite um número para inserir na árvore. Digite 's' para sair.");

            while (true)
            {
                Console.Write("Insira um número: ");
                input = Console.ReadLine();

                if (input?.ToLower() == "s")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    myTree.Insert(number);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número ou 's' para sair.");
                }
            }

            myTree.PrintTree();

            // Lógica para buscar um número na árvore
            Console.Write("\n\nDigite um número para buscar na árvore: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out int searchNumber))
            {
                Node? result = myTree.Search(searchNumber);

                if (result != null)
                {
                    Console.WriteLine($"\nO número {searchNumber} foi encontrado na árvore!");
                }
                else
                {
                    Console.WriteLine($"\nO número {searchNumber} não foi encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }
    }
}
