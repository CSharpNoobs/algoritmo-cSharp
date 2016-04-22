/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_13
 * 
 * Faça um algoritmo que calcule a area de um triangulo lendo a base e o altura. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara as variáveis
            double baseTriangulo, altura, area = 0;

            // exibe no console
            Console.Write("Entre com a base do triângulo : ");
            baseTriangulo = double.Parse(Console.ReadLine());    // lê a base do triângulo
 
            // exibe no console
            Console.Write("Entre com a altura do triângulo : ");
            altura = double.Parse(Console.ReadLine());    // lê altura do triângulo 

            // processamento
            area = (baseTriangulo * altura) / 2;

            // saída ou solução do program
            Console.Write("A Área do Triângulo é : " + area);
            
            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}

