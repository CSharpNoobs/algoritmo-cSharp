/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_42
 * 
 * Todo restaurante, embora por lei não possa obrigar o cliente a pagar, cobra 10% para o garçom. 
 * Fazer um algoritmo que leia o valor gasto com despesas realizadas em um restaurante e imprima o valor total com a gorjeta.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_42
{
    class Program
    {
        static void Main(string[] args)
        {
            double cres = 0;
            double cgorj = 0;
            double total = 0;

            Console.Write("Entre com o valor da conta : ");
            cres = double.Parse(Console.ReadLine());

            cgorj = cres * 0.1;
            total = cres + cgorj;

            Console.Write("O valor da conta com a comissão do garçon é de R$" + total );
            Console.ReadKey();
            
        }
    }
}
