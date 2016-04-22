/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_15
 * 
 * Faça um algoritmo que receba três números, calcule e mostre a multiplicação desses números 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara as variáveis
            double numero1, numero2, numero3 = 0;
            double produto = 0;

            // exibe no console
            Console.Write("Digite o número 1 : ");
            numero1 = double.Parse(Console.ReadLine());   // lê número 1

            // exibe no console
            Console.Write("Digite o número 2 : ");
            numero2 = double.Parse(Console.ReadLine());   // lê número 2

            // exibe no console
            Console.Write("Digite o número 3 : ");
            numero3 = double.Parse(Console.ReadLine());   // lê número 3

            // processamento 
            produto = numero1 * numero2 * numero3;

            // saida ou solução do programa
            Console.Write("A multiplicação dos três números é igual a : " + produto);

            Console.ReadKey();
        }
    }
}
