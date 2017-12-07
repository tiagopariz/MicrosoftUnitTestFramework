using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Domain;

namespace Calculadora.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOMA\n\n");

            Console.WriteLine("Digite um número");
            var n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            var n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultado da soma: ");
            var soma = new Soma(n1, n2);
            Console.WriteLine(soma.Resultado());

            Console.ReadKey();


            Console.WriteLine("DIVISÃO\n\n");

            Console.WriteLine("Digite um número");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultado da divisão: ");
            var divisao = new Divisao(n1, n2);
            Console.WriteLine(divisao.Resultado());

            Console.ReadKey();
        }
    }
}
