/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_29
 * 
 * Fazer um algoritmo para calcular o custo estimado de gasto com combustível em uma viagem de carro.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_29
{
    class Program
    {
        static void Main(string[] args)
        {
            // incializa e declara variáveis
            double kmLitro = 0;
            double distancia = 0;
            double precoLitro = 0;
            double custo = 0;
            
            // exibe no console
            Console.Write("Quantos quilomentos por litros o seu carro faz ? ");
            kmLitro = double.Parse(Console.ReadLine());  // lê kilomentros por litros

            // exibe no console
            Console.Write("Qual a distância da viagem em Km ? ");
            distancia = double.Parse(Console.ReadLine());  // lê a distância

            Console.Write("Qual o preço do litro do combustivel em R$ ? ");
            precoLitro = double.Parse(Console.ReadLine());

            // processamento
            custo = distancia/kmLitro*precoLitro;

            //saída ou solução
            Console.Write("O custo estimado da viagem sera R$ " + custo);

            // espera entrada do teclado para encerrar o programa
            Console.ReadKey();

        }
    }
}
