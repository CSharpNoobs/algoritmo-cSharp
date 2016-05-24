/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_44
 * 
 * Algoritmo que converta Pés em metros. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_45
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pes = 0.30480d;
            double metros = 0;
            double converter = 0;

            Console.Write("Entre com o valor em metros : ");
            metros = double.Parse(Console.ReadLine());

            converter = metros * pes;

            Console.Write(metros + " metros convertidos em pés = " + converter + " pés");

            Console.ReadKey();
        }
    }
}
