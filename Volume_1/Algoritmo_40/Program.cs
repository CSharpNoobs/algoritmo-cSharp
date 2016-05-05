/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_40
 * 
 * Antes de o racionamento de energia ser decretado, quase ninguém falava em quilowatts; mas, agora, todos incorporaram essa palavra em seu vocabulário. Sabendo-se que 100 quilowatts de energia custa um sétimo do salário mínimo, fazer um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts gasta por uma residência e calcule. Imprima 
 * o valor em reais de cada quilowatt 
 * o valor em reais a ser pago 
 * o novo valor a ser pago por essa residência com um desconto de 10%. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_40
{
    class Program
    {
        static void Main(string[] args)
        {
            double sm = 0;
            double qtdade = 0;
            double preco = 0;
            double vp = 0;
            double vd = 0;

            Console.Write("Entre com o salário mínimo : ");
            sm = double.Parse(Console.ReadLine());

            Console.Write("Entre com a quantidade em quilowatt : ");
            qtdade = double.Parse(Console.ReadLine());

            // processamento
            preco = sm / 700; // divide por 7 para achar o preço de 100 kw e por 100 para achar de 1kw
            vp = preco * qtdade;
            vd = vp * 0.9;

            Console.Write("Preço do quilowatt : " + preco + "\n");
            Console.Write("Valor a ser pago   : " + vp +    "\n")
        }
    }
}
