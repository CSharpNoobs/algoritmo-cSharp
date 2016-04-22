/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_22
 * 
 * Faça um algoritmo para converter dólar em reais
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializar e declarar variáveis 
            double reais = 0;
            double taxa = 3.74d;
            double dolar = 0;

            // exibi no console
            Console.Write("Entre com o valor em dólar : ");
            dolar = double.Parse(Console.ReadLine()); // lê o dolar

            // processamento do valor em reais
            reais = taxa * dolar;

            // saída ou solução
            Console.Write("Valor em Reais : $R" + reais);

            // espera entrada do teclado para encerrar programa
            Console.ReadKey();
        }
    }
}
