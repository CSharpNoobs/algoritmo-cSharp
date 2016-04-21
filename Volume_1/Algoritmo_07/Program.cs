/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_07
 * 
 * O restaurante a quilo Bem-Bão cobra R$12,00 por cada quilo de refeição. Escreva um algoritmo
 * que leia o peso do prato montado pelo cliente (em quilos) e imprima o valor a pagar. Assuma que a 
 * balança já desconte o peso do prato.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // declara e inicia variáveis 
            const double KG = 12d;
            double peso = 0;  // variáveis numéricas inicializadas com 0
            double pagar = 0;
           
             // exibe no console   
            Console.Write("Entre com o peso : ");
            peso = double.Parse(Console.ReadLine());   // lê o peso

            // processa o valor a pagar
            pagar = peso * KG;

            // exibe a saida ou resultado do programa 
            Console.Write("Valor a pagar : " + pagar);

            Console.ReadKey();    // espera entrada do teclado para finalizar aplicação  
        }
    }
}
