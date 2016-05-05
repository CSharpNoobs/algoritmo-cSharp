/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_39
 * 
 * Efetuar o cálculo do valor de uma prestação em atraso, utilizando a fórmula:
 * prestação =valor+ (valor*(taxa/100)*tempo).  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_41
{
    class Program
    {
        static void Main(string[] args)
        {
            double prest = 0;
            double valor = 0;
            double taxa = 0;
            int tempo = 0;

            Console.Write("Digite o valor da prestação : ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Digite o a taxa : ");
            taxa = double.Parse(Console.ReadLine());

            Console.Write("Digite o tempo(número de meses) : ");
            tempo = int.Parse(Console.ReadLine());

            // processamento 
            prest = valor + (valor * (taxa / 100) * tempo);

            // saída
            Console.Write("\nValor da prestação em atraso é = " + prest + "\n");
            Console.ReadKey();
        }
    }
}
