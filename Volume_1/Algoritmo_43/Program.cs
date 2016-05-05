/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_43
 * 
 * Criar um algoritmo que leia um valor de hora e informe quantos minutos se passaram desde o início do dia. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_43
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = 0;
            int tminuto = 0;
            int minuto = 0;

            Console.Write("Entre com hora atual : ");
            hora = int.Parse(Console.ReadLine());

            Console.Write("Entre com minutos : ");
            minuto = int.Parse(Console.ReadLine());

            // processamento
            tminuto = hora * 60 + minuto;

            // saída
            Console.Write("Até agora se passaram : " + tminuto + " minutos\n");
            Console.ReadKey();
        }
    }
}
