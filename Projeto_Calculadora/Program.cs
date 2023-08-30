using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine();
            Console.Write("Qual operação deseja fazer?: ");
            int operacao = int.Parse(Console.ReadLine());


            Console.Write("Digite o primeiro número: ");
            int primeiro_num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int segundo_num = int.Parse(Console.ReadLine());
        }
    }
}
