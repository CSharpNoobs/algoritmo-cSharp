/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_30
 * 
 * Faça algoritmo que receba o salário de um funcionário e o percentual de aumento e calcule e mostre o valor do
 * aumento e o novo salário.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_30
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicia e delcara variáveis
            double salario = 0;
            double aumento = 0;
            double novoSalario;

            // exibe no console
            Console.Write("Digite o valor do salario : ");
            salario = double.Parse(Console.ReadLine());  // lê salário

            // exibe no console
            Console.Write("Digite o valor do aumento em porcentagem : ");
            aumento = double.Parse(Console.ReadLine());  // lê aumento em porcentagem

            // processamento
            aumento = salario * (aumento / 100);
            novoSalario = aumento + salario;

            // saída
            Console.Write("O valor do aumento é : R$" + aumento + "\n");

            Console.Write("O valor do novo salário : R$" + novoSalario + "\n");

            // espera entrada de teclado para encerrar o programa
            Console.ReadKey();

        }
    }
}
