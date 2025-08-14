using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um número para fatoriar aí");
            int num = int.Parse(Console.ReadLine());

            int fator = fatorial(num);

            Console.WriteLine("O fatoral de {0} é {1}.", num, fator);

            Console.ReadKey();


        }

        static int fatorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * fatorial(num - 1);
            }

        }
    }
}
