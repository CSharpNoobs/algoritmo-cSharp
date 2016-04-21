/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_04
 * 
 * A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as 
 * dimensões de um terreno e depois exibir a área do terreno. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // declara e inicializa as variáveis nesse caso nao pude usar base pois e palavra reservada do c#
            double baseRectangle = 0;
            double altura = 0;
            double area = 0;

            // exibe no console
            Console.Write("Entre com a base do terreno : ");
            baseRectangle = double.Parse(Console.ReadLine());   // lê a base do terreno retângular 

            // exibe no console
            Console.Write("Entre com a altura do terreno : ");
            altura = double.Parse(Console.ReadLine());          // lê a altura do terreno retângular 

            area = baseRectangle * altura;

            // saida da area do terre
            Console.Write("A área do terreno é : " + area);

            Console.ReadKey();  // espera a entrada do teclado para encerrar a aplicação.
        }
    }
}
