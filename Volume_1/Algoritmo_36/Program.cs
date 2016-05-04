/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_36
 * 
 * Faça um algoritmo que receba um valor que foi depositado e exiba o
 * valor com rendimento após um mês. Considere fixo o juro da
 * poupança em 0,70% a. m.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_36
{
    class Program
    {
        static void Main(string[] args)
        {
            double juros = 0.7;
            double deposito = 0;
            double rendimento = 0;
            double total  = 0;

            Console.Write("Digite o valor depositado : ");
            deposito = double.Parse(Console.ReadLine());

            // processamento
            rendimento = juros * deposito;

            total = deposito + rendimento;

            Console.Write("O rendimento do depósito após um més é de um total de : " + total);
            
            Console.ReadKey();
        }
    }
}
