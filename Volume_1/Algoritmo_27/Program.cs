/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_27
 * 
 * Faça um algoritmo que:
 * a) Obtenha o valor para a variável HT (horas trabalhadas no mês);
 * b) Obtenha o valor para a variável VH (valor hora trabalhada):
 * c) Obtenha o valor para a variável PD (percentual de desconto);
 * d) Calcule o salário bruto => SB = HT * VH;
 * e) Calcule o total de desconto => TD = (PD/100)*SB;
 * f) Calcule o salário líquido => SL = SB – TD;
 * g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário
 * Liquido. Apresente o nome completo. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_27
{
    class Program
    {
        static void Main(string[] args)
        {
            double HT = 0;
            double VH = 0;
            double PD = 0;
            double SB = 0;
            double TD = 0;
            double SL = 0;

            Console.Write("Entre com as horas trabalhadas no mês : ");
            HT = double.Parse(Console.ReadLine());

            Console.Write("Entre com o valor da hora Trabalhada : ");
            VH = double.Parse(Console.ReadLine());

            Console.Write("Entre com o percentual de desconto : ");
            PD = double.Parse(Console.ReadLine());

            // salário bruto
            SB = HT * VH;

            // total de desconto
            TD = (PD / 100) * SB;

            // salario liquido
            SL = SB - TD;

            // saida
            Console.Write("Horas Trabalhadas : " + HT + "\n");
            Console.Write("Salário Bruto     : " + SB +     "\n");
            Console.Write("Total de Desconto : " + TD + "\n");
            Console.Write("Salário Líquido   : " + SL +   "\n");

            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}
