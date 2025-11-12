using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>
        {
            "Ana",
            "Bruno",
            "Carla",
            "Diego",
            "Eduarda",
            "Felipe",
            "Gabriela",
            "Henrique",
            "Isabela",
            "João"
        };


            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }


            Console.WriteLine("Pesquise algum nome na lista: ");
            string busca = Console.ReadLine()?.ToUpper();

            bool Seacher = false;

            if (busca != null)
            {

                for (int i = 0; i < 10; i++)
                {
                    if (busca == nomes[i].ToUpper())
                    {
                        Console.WriteLine("Nome Encontrado na posição {0}", i + 1);
                        Seacher = true;
                        break;
                    }
                }
            }

            if (!Seacher)
                Console.WriteLine("Nome não encontrado");
        }

    }
}
