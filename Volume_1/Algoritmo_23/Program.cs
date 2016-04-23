/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_23
 * 
 * Faça um algoritmo para converter euro em real;
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara as variáveis 
            double reais = 0;
            double taxa = 0;
            double euro = 0;

            //exibe no console
            Console.Write("Entre com o valor em euro : ");
            euro = double.Parse(Console.ReadLine());   // lê o valor do euro

            //exibe no console
            Console.Write("Entre com a taxa do euro : ");
            taxa = double.Parse(Console.ReadLine());   // lê o valor da taxa  

            // processamento do valor em reais
            reais = taxa * euro; 

            // saida ou solução
            Console.Write("Valor em reais : R$" + reais);

            // espera entrada de teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}
