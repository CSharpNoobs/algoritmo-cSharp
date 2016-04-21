/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_06
 * 
 *  Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida 
 *  ela possui. Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa 
 *  com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 
 *  Dias
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializando e declarando as variáveis
            string nome = "";
            int idade = 0;
            const int ANO = 365;
            int resultado = 0;

            Console.Write("Entre com seu nome : ");
            nome = Console.ReadLine();

            Console.Write("Entre com sua idade : ");
            idade = int.Parse(Console.ReadLine());

            // processamento da conversão da idade em anos para idade em dias
            resultado = idade * ANO;

            Console.Write(nome + " , Você ja viveu " + resultado + " dias");

            Console.ReadKey();  // espera entrada de teclado para encerrar o programa 
        }
    }
}
