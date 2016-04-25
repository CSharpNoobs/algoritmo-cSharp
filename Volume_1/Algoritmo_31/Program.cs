/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_31
 * 
 * Faça um algoritmo que receba o salário-base de um funcionário, calcule e mostre seu salário a receber, Sabendo
 * se que esse funcionário tem gratificação de R$ 50,00 e paga imposto de 10% sobre o salário-base.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_31
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaro e inicializa variáveis
            double salario = 0;
            double imposto = 0;
            double novoSalario = 0;

            //exibe no console
            Console.Write("Digite o salário-base do funcionário : ");
            salario = double.Parse(Console.ReadLine());   // lê salario base

            // processamento
            imposto = salario * 0.10;
            novoSalario = (salario - imposto) + 50;

            // saída e solução
            Console.Write("O salario que o funcionario tem a receber é : R$" + novoSalario);

            // espera entrada de teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}
