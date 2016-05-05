/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_38
 * 
 * Entrar com um número no formato CDU e imprimir invertido: UDC. (Exemplo: 123, sairá 321.) 
 * O número deverá ser armazenado em outra variável antes de ser impresso. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int c = 0;
            int d = 0;
            int u = 0;
            int num1 = 0;

            Console.Write("Entre com um número : ");
            num = int.Parse(Console.ReadLine());

            // processamento
            c = num / 100;
            d = (num % 100) / 10;
            u = num % 10;

            num1 = u * 100 + d * 10 + c;

            // saída
            Console.Write("Número    : " + num +  "\n");
            Console.Write("Invertido : " + num1 + "\n");

            Console.ReadKey();
             

        }
    }
}
