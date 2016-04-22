/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_08
 * 
 * Faça um algoritmo para ler três notas de um aluno em uma disciplina e imprimir a sua média 
 * ponderada (as notas tem pesos respectivos de 1, 2 e 3). 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara as variáveis do programa
            double nota1, nota2, nota3, media = 0;
           
            // exibe no console
            Console.Write("Entre com a nota 1 : ");
            nota1 = double.Parse(Console.ReadLine());    // lê a variável nota1

            Console.Write("Entre com a nota 2 : ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 3 : ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            // exibe a saida ou resultado do programa
            Console.Write("A média ponderada é : " + media);

            Console.ReadKey();   // espera entrada do teclado para finalizar o programa
        }
    }
}
