/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_12
 * 
 * Faça um algoritmo que calcule a area de um quadrado lendo o lado. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara as variáveis
            double lado = 0;
            double area = 0;

            // exibe no console
            Console.Write("Entre com o valor do lado do quadrado : ");
            lado = double.Parse(Console.ReadLine());   // lê o lado

            // processamento
            area = lado * lado;

            // saida ou resultado do programa
            Console.Write("Área do quadrado é : " + area + " metros quadrados");

            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();

        }
    }
}
