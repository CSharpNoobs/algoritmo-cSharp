/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_39
 * 
 * Entrar com quatro números e imprimir a média ponderada, sabendo-se que os pesos são respectivamente: 1, 2, 3 e 4. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_39
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double mp = 0;

            // exibi no console
            Console.Write("Entre com o primeiro número : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo número : ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Entre com o terceiro número : ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Entre com o quarto número : ");
            d = double.Parse(Console.ReadLine());

            // processamento
            mp = (a * 1 + b * 2 + c * 3 + d * 4) / 10;
 
            // saida
            Console.Write("\nMedia ponderada : " + mp + "\n");
            Console.ReadKey();
        }
    }
}
