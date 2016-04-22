/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_21
 * 
 * Faça um algoritmo para ler um preço de um produto em reais e a taxa de conversão do dólar e informar
 * o preço do produto em dólares.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara variáveis 
            double precoReal = 0;
            double taxa = 3.74d;
            double conversao = 0;

            // exibe no console
            Console.Write("Entre com preço em Real : ");
            precoReal = double.Parse(Console.ReadLine());   // lê o preço em real 

            // processamento para conversão em dólar
            conversao = precoReal / taxa;

            // saída ou solução 
            Console.Write("Preço convertido em dolar : $" + conversao + " dolares");

            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}
