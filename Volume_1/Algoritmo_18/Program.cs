/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_18
 * 
 * Faça um algoritmo que leia os catetos de um triangulo e exiba o valor da hipotenusa
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // incicializa e declara variáveis
            double a, b = 0;
            double hipotenusa = 0;
            
            // exibe no console
            Console.Write("Entre com o valor do primeiro cateto : ");
            a = double.Parse(Console.ReadLine());    // lê o primeiro cateto

            // exibe no console
            Console.Write("Entre com o valor do segundo cateto : ");
            b = double.Parse(Console.ReadLine());    // lê o segundo cateto    

            // processamento utilizando a biblioteca Math para usar a raiz quadrada
            hipotenusa = Math.Sqrt((a * a) + (b * b));

            // saída ou resultado do programa
            Console.Write("Hipotenusa : " + hipotenusa);

            // espera entrada do teclado para fechar o programa
            Console.ReadKey();
        }
    }
}
