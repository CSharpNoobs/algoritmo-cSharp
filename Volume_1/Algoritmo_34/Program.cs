/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_34
 * 
 * Faça um algoritmo que leia um valor inteiro e apresente os resultados do
 * quadrado e do cubo do valor lido.  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_34
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara as variáveis
            int valor = 0;
            int quadrado = 0;
            int cubo = 0;

            Console.Write("Entre com um valor inteiro : ");
            valor = int.Parse(Console.ReadLine());

            quadrado = valor * valor;
            cubo = valor * valor * valor;

            Console.Write("Quadrado : " + quadrado + "\n");
            Console.Write("Cubo     : " + cubo +     "\n");

            Console.ReadKey();
        }
    }
}
