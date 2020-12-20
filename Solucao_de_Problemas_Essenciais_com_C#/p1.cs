/*
Desafio
Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.
*/

using System;

namespace desafio1
{
    class QuadradoECubo
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            
            int Num = 1;
            int Quad = 1;
            int Cub = 1;
            
            for(int i = 0; i < N; i++)
            {
                Quad = Num * Num;
                Cub = Quad * Num;
                
                Console.WriteLine($"{Num} {Quad} {Cub}");
                
                Num += 1;
            }
        }
    }
}