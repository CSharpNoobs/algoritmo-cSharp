/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_36
 * 
 * Ler um número inteiro e imprimir seu sucessor e seu antecessor. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_37
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int ant = 0;
            int suc = 0;

            Console.Write("Entre com um numero : ");
            numero = int.Parse(Console.ReadLine());

            // processamento 
            ant = numero - 1;
            suc = numero + 1;

            Console.Write("Antecessor = " + ant + " do núrmero " + numero + " e o sucessor = " + suc);
            Console.ReadKey();
        }
    }
}
