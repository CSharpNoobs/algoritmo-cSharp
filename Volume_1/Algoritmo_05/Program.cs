/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_05
 * 
 * Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o 
 * preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu colocar no 
 * tanque.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicia e declara as variáveis 
            double abastecimento = 0;
            const double LITRO = 3.74d;
            double qtd_litros = 0;
            
            // exibe no console
            Console.Write("Qual o valor que deseja abastacer : ");
            abastecimento = double.Parse(Console.ReadLine());   // lê o valor do abastecimento

            qtd_litros = abastecimento / LITRO; // processamento para quantidade de litros

            // exibe resultado.
            Console.Write("Litros abastecido com o valor de RS" + abastecimento + " foi de : " + qtd_litros);

            Console.ReadKey(); // espera entrada do teclado para encerrar a aplicação
        }
    }
}
