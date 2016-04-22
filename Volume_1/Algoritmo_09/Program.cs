/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_09
 * 
 * Faça um algoritmo para ler dois numeros e fazer as operaçoes aritméticas básicas com eles. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara variáveis
            int numero1, numero2, soma, subtracao, multiplicacao, divisao = 0;

            // exibe no console
            Console.Write("Digite o numero 1 : ");
            numero1 = int.Parse(Console.ReadLine());   // lê numero1 

            // exibe no console
            Console.Write("Digite o numero 2 : ");
            numero2 = int.Parse(Console.ReadLine());   // lê numero2

            soma           =  numero1 + numero2;       // processamento da operação soma  
            subtracao      =  numero1 - numero2;       // processamento da operação subtração 
            multiplicacao  =  numero1 * numero2;       // processamento da operação multiplicação
            divisao        =  numero1 / numero2;       // processamento da operação divisão

            // exibe a saida do programa ou a solução do problema 
            Console.Write("Soma : " + soma);
            Console.Write(" Subtração : " + subtracao);
            Console.Write(" Multiplicação : " + multiplicacao);
            Console.Write(" Divisão : " + divisao);

            Console.ReadKey();
        }
    }
}
