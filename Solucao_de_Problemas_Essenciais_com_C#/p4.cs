/*
Desafio
Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para que você desenvolva um programa que calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

Entrada
A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.
*/

using System;

namespace desafio4
{
    class ValidacaoNota
    {
        static void Main(string[] args)
        {
            int ContNotaValid = 0;
            double nota = 0;
            double soma = 0;
            double mediaSem = 0;
            
            while (ContNotaValid < 2)
            {
                nota = double.Parse(Console.ReadLine());
              
                if (nota >= 0 && nota <= 10)
                {
                    soma += nota;
                    ContNotaValid += 1;
                }
                else
                {
                  Console.WriteLine("nota invalida");
                }
            }
            
            mediaSem = soma / ContNotaValid;
            Console.WriteLine("media = " + mediaSem.ToString("N2"));
        }
    }
}
