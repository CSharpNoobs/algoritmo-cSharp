/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_14
 * 
 * Faça um algoritmo que calcule a area de um circulo lendo o raio dele. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // declara e inicializa variável e constante
            const double PI = 3.14d;
            double raio = 0;
            double area = 0;

            // exibe no console
            Console.Write("Entre com o raio do circulo : ");
            raio = double.Parse(Console.ReadLine());   // lê raio 
            
            // processamento
            area = PI * (raio * raio);

            // saida ou solução do program
            Console.Write("Área do Círculo : " + area);

            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();
            
        }
    }
}
