/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_20
 * 
 * Faça um algoritmo para ler uma temperatura dada na escala Fahrenheit e exibir o equivalente em Celsius.
 * C = 5/9(F-32)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara as variáveis
            double f;
            double c;

            // exibe no console
            Console.Write("Entre com a temperatura na escala Fahrenheit : ");
            f = double.Parse(Console.ReadLine()); // le a temperatura fahrenheit

            // processamento
            c = (double)5/9 * (f - 32);

            // saida ou solução
            Console.Write("A temperatura em Celsius é igual a : " + c);

            // espera entrada do teclado para encerrar a aplicação
            Console.ReadKey();



        }
    }
}
