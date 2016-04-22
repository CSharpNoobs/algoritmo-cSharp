/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_10
 * 
 * Faça um algoritmo que leia um número e imprima seu dobro. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara variáveis
            int numero = 0;
            int dobro = 0;

            // exibe no console
            Console.Write("Entre com um numero : ");
            numero = int.Parse(Console.ReadLine());   // lê o numero

            // processamento 
            dobro = numero * 2;

            // saida ou solução do programa 
            Console.Write("O dobro do numero " + numero + " é : " + dobro);

            Console.ReadKey();   // espera entrada de teclado para encerrar o programa 
        }
    }
}
