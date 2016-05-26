/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_15
 * 
 * . Calcule o volume de uma caixa d'água cilíndrica. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa variáveis e constante
            const double PI = 3.14d;
            double raio = 0;
            double altura = 0;
            double area = 0;

            // exibe no console
            Console.Write("Entre com o raio da caixa d' agua cilindrica : ");
            raio = double.Parse(Console.ReadLine());   // lê raio  

            // exibe no console
            Console.Write("Entre com a altura da caixa d'agua cilindrica : ");
            altura = double.Parse(Console.ReadLine()); // lê altura

            // processamento
            area = (PI * (raio * raio)) * altura;

            // saída ou solução
            Console.Write("Volume da caixa d'agua cilindrica é " + area);
            
            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();


        }
    }
}
