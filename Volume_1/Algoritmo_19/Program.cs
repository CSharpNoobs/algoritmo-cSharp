/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_19
 * 
 * Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento
 * desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa e declara variáveis
            double salario = 0;
            double salarioAumento = 0;
            double salarioFinal = 0;
           
            // exibe no console
            Console.Write("Entre com o salario do funcionario : ");
            salario = double.Parse(Console.ReadLine()); // lê salário inicial do aluno

            // imprime salario inicial
            Console.Write("Salário inicial é de : " + salario +            "\n");
            
            // processa salário com aumento 
            salarioAumento = salario + (salario * 0.15);
            Console.Write("Salário com aumento é de : " + salarioAumento + "\n");  // imprime salário com aumento
 
            // processa salário final
            salarioFinal = salarioAumento - (salarioAumento * 0.08);
            Console.Write("Salário final é de : " + salarioFinal +        "\n");   // imprimie salario final

            // espera entrada do teclado para encerrar o programa.
            Console.ReadKey();


            

        }
    }
}
