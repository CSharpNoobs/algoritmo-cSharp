/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_06
 * 
 * Ler um número inteiro (assuma até três dígitos) e imprimir a saída da seguinte forma:
 * CENTENA = x
 * DEZENA  = x
 * UNIDADE = x
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int centena, dezena, unidade = 0;

            // exibe no console
            Console.Write("Entre com um número inteiro de 0 até 999:");
            numero = int.Parse(Console.ReadLine());

            // processamento
            centena = numero / 100;

            // o que sobrar depois que tirarmos as centenas, são as dezenas
            dezena = (numero % 100) / 10;

            // o que sobrar depois que tirarmos as centenas e dezenas sao as unidades
            unidade = ((numero % 100) % 10);

            Console.Write("Centenas : " + centena + "\n");
            Console.Write("Dezenas  : " + dezena +  "\n");
            Console.Write("Unidades : " + unidade + "\n");

            // espera entrada de teclado para encerrar o programa
            Console.ReadKey();

        }
    }
}
