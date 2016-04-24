/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_28
 * 
 * Faça um algoritmo que leia dois valores para as variáveis A e B e efetue a troca
 * dos valores de forma que a variável A passe a possuir o valor da variável B e a
 * variável B passe a possuir o valor da variável A. Apresente os valores trocados.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara variáveis 
            int A, B, AUX = 0;

            // exibe no console
            Console.Write("Entre com o valor de A : ");
            A = int.Parse(Console.ReadLine());   // lê A

            // exibe no console
            Console.Write("Entre com o valor de B : ");
            B = int.Parse(Console.ReadLine());  // lê B  

            // saída
            Console.Write("Valores de A e B antes da troca sao respectivamente " + A + " e " + B + "\n");

            // troca utilzando variável auxiliar
            AUX = A;
              A = B;
              B = AUX;

            // saída
            Console.Write("Valores de A e B após a troca sao respectivamente " + A + " e " + B + "\n");

            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}
 