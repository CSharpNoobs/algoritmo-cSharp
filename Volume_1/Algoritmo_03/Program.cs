/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_03
 * 
 * Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os
 * cavalos de um haras.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_03
{
    class Program
    {
        static void Main(string[] args)
        { 
            // inicia e declara todas as variáveis necessárias
            const int FERRADURAS = 4;    // declaração de uma constante ou seja não mudará ao decorrer do programa.
            int quantidade_cavalos = 0;
            int resultado = 0;           // armazenára a quantidade de ferraduras para equipar os cavalos

            // exibe no console 
            Console.Write("Entre com a quantidade de cavalos do seu Haras : ");
            quantidade_cavalos = int.Parse(Console.ReadLine()); // lê a quantidade de cavalos do haras

            resultado = FERRADURAS * quantidade_cavalos; // faz o processamento da quantidade de ferraduras

            // por fim exibe a saída ou resultado do programa.
            Console.Write("Quantidade de Ferraduras para equipar todos seus cavalos serão : " + resultado);

            Console.ReadKey();  // espera entrada do teclado para encerrar o programa 

        }
    }
}
