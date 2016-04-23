/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_24
 * 
 * Faça um algoritmo para converter real em euro;
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double euros = 0;
            double taxa = 0;
            double real = 0;

            // exibe no console
            Console.Write("Entre com a quantidade de Reais : ");
            real = double.Parse(Console.ReadLine());   // lê real

            // exibe no console
            Console.Write("Entre com o valor da taxa do euro : ");
            taxa = double.Parse(Console.ReadLine());  // lê taxa
 
            // processamento de conversão de reais em euro
            euros = real / taxa;

            // saida ou solução 
            Console.Write("Valor em euros : " + euros + " euros");

            // espera entrada de teclado para encerrar o programa
            Console.ReadKey();

        }
    }
}
