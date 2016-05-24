/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_44
 * 
 * Algoritmo que converta km/h para mph. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_44
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mph = 1.6093d;
            double kmh = 0;
            double converter = 0;

            Console.Write("Entre a velocidade em km/h : ");
            kmh = double.Parse(Console.ReadLine());

            converter = kmh * mph;

            Console.Write(kmh + " Km/h convertido em Mhp = "+ converter + " mph");

            Console.ReadKey();
        }
    }
}
