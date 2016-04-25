/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_33
 * 
 * Faça um algoritmo que leia dois valores inteiros (A e B) e apresente o resultado
 * do quadrado da soma dos valores lidos. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_33
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara variáveis
            int A = 0;
            int B = 0;
            int QA = 0;
            int QB = 0;
            int soma = 0;

            // exibe no console
            Console.Write("Entre com o valor de A : ");
            A = int.Parse(Console.ReadLine());   // lê A

            // exibe no console
            Console.Write("Entre com o valor de B : ");
            B = int.Parse(Console.ReadLine());   // lê B

            QA = A * A;
            QB = B * B;

            // processamento
            soma = QA + QB;

            // saída ou solução
            Console.Write("A soma do quadrado de A e B é : " + soma + "\n");

            // espera entrada de teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}
