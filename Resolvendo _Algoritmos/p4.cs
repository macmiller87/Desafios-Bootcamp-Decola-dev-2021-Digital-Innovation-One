/*
Desafio
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
*/

using System;

namespace desafio4
{
    class ConversaoDeTempo
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var horas = N/3600;
            var minutos = (N%3600)/60;
            var segundos = (N%3600)%60;

            Console.Write($"{horas}:{minutos}:{segundos}");
        }
    }
}