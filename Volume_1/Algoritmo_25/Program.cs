/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_24
 * 
 * Faça um calculo de Juros Simples, digitando o valor inicial,
 * a quantidade de meses que será pago esse valor e a porcentagem de 
 * juros mensais. Ex: Um empréstimo no valor de 2.000,00, com juros 
 * mensais de 8% e a quantidade de 6 meses de pagamento, totalizando
 * o valor de 2.960,00 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double valor = 0;
            int qtdmeses = 0;
            double juros = 0;

            Console.Write("Entre com o valor do emprestimo : ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Entre com a quantidade de meses ou parcelas do emprestimo : ");
            qtdmeses = int.Parse(Console.ReadLine());

            Console.Write("Entre com a taxa de juros : ");
            juros = double.Parse(Console.ReadLine());

            // processamento do valor pago ao final da quantidade de meses do emprestimo
            total = valor + ((qtdmeses * (juros / 100)) * valor);

            // saída ou solução 
            Console.Write("Valor pago ao final da quantidade de " + qtdmeses + " meses do emprestimo : " + total);

            // espera entrada de teclado para encerrar o programa
            Console.ReadKey();

        }
    }
}
