/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_11
 * 
 * Faça um algoritmo que leia um número e imprima seu quadrado. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara variáveis 
            double numero = 0;
            double quadrado = 0;

            // exibe no console
            Console.Write("Entre com um número : ");
            numero = double.Parse(Console.ReadLine());

            // processamento
            quadrado = numero * numero;

            // saída ou solucção do programa
            Console.Write("O quadrado do numero " + numero + " é : " + quadrado);

            // espera uma entrada do teclado para fechar o programa
            Console.ReadKey();
        }
    }
}
