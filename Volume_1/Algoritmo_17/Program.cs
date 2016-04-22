/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_17
 * 
 * Faça um algoritmo que calcule e mostre a área de um losango. Sabe-se que: A = 
 * (diagonal_maior * diagonal_menor)/2;  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara variáveis
            double area = 0;
            double diagonalMaior = 0;
            double diagonalMenor = 0;

            // exibe no console
            Console.Write("Entre com a diagonal Maior do losango : ");
            diagonalMaior = double.Parse(Console.ReadLine());   // lê diagonal maior 

            // exibe no console
            Console.Write("Entre com a diagonal Menor do losango : ");
            diagonalMenor = double.Parse(Console.ReadLine());   // lê diagonal menor

            // processamento o
            area = (diagonalMaior * diagonalMenor) / 2;

            // saida ou solução do programa
            Console.Write("Área do losango : " + area);

            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}
