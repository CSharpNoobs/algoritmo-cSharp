/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_31
 * 
 * Faça um algoritmo que leia os valores de COMPRIMENTO, LARGURA e
 * ALTURA e apresente o valor do volume de uma caixa retangular. Utilize para o
 * cálculo a fórmula VOLUME =  COMPRIMENTO * LARGURA * ALTURA
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_32
{
    class Program
    {
        static void Main(string[] args)
        {
            // incializa e declara variáveis 
            double volume = 0;
            double comprimento = 0;
            double largura = 0;
            double altura = 0;

            // exibe no console
            Console.Write("Entre com o comprimento : ");
            comprimento = double.Parse(Console.ReadLine());  // lê comprimento

            // exibe no console
            Console.Write("Entre com a largura : ");
            largura = double.Parse(Console.ReadLine());  // lê largura

            // exibe no console
            Console.Write("Entre com a altura : ");
            altura = double.Parse(Console.ReadLine());   // lê altura

            // processamento
            volume = comprimento * largura * altura;

            // saída ou solução
            Console.Write("Volume da caixa retangular é : " + volume + "metros cubicos\n");

            // espera entrada de teclado para encerrar o programa
            Console.ReadKey();



        }
    }
}
