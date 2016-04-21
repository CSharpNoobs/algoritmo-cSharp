/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_02
 * 
 * Faça um algoritmo para ler : a descrição do produto (nome), a quantidade adquirida, o preço unitário 
 * e o percentual (%) de desconto. Calcular e escrever o total bruto (total_bruto = quantidade adiquirida * 
 * preço unitário), o total de desconto,  o total a pagar (total a pagar = total_bruto - desconto).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_02
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Inicializa todas as variáveis 
            String nome    = "";     // alfanúmericas com aspas duplas
            int    quantidade = 0;   // númericas com zero
            double preco   = 0;
            double percentual_desc = 0;
            double total_desconto = 0; 
            double total_bruto = 0;


            Console.Write("Entre com o nome do Produto : ");    // exibir no console
            nome = Console.ReadLine();                          // lê dados

            Console.Write("Entre com a quantidade : ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write("Entre com preço do produto : ");
            preco = double.Parse(Console.ReadLine());

            Console.Write("Entre com o percentual de desconto : ");
            percentual_desc = double.Parse(Console.ReadLine());

            total_bruto = quantidade * preco;    // processamento do total bruto

            // processamento total com desconto em cima da porcentagem
            total_desconto = total_bruto - ((percentual_desc / 100) * total_bruto);  

            // exibe o resultado do problema que é o total com o desconto 
            Console.Write("Total com desconto : " + total_desconto);

            Console.ReadKey(); // pausa o console até que algum evento do teclado seja executado
        }
    }
}
