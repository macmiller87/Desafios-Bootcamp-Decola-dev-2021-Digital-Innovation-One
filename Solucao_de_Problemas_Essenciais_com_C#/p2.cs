/*
Desafio
A corrida de tartarugas é um esporte que cresceu muito nos últimos anos, fazendo com que vários competidores se dediquem a capturar tartarugas rápidas, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de capturar tartarugas não é uma tarefa muito fácil, pois quase todos esses répteis são bem lentos. Cada tartaruga é classificada em um nível dependendo de sua velocidade:


Nível 1: Se a velocidade é menor que 10 cm/h .
Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
Nível 3: Se a velocidade é maior ou igual a 20 cm/h .

Sua tarefa é identificar qual o nível de velocidade da tartaruga mais veloz de um grupo.

Entrada
A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro L (1 ≤ L ≤ 500) representando o número de tartarugas do grupo, e a segunda linha contém L inteiros Vi (1 ≤ Vi ≤ 50) representando as velocidades de cada tartaruga do grupo.

Saída
Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da tartaruga mais veloz do grupo.
*/

using System;

namespace desafio3_2
{
    class CorridaDeTartarugas 
    {
        static void Main() 
        {
            string[] maiorNvlVel = new string[3];
            for (int i = 0; i < 3; i++)
            {
                string QtdTartaruga = Console.ReadLine();
                string NvlVelocidade = Console.ReadLine();
                if(Nvl3(QtdTartaruga, NvlVelocidade) == true)
                {
                    maiorNvlVel[i] = "3";
                }
                else if(Nvl2(QtdTartaruga, NvlVelocidade) == true)
                {
                    maiorNvlVel[i] = "2";
                }
                else 
                {
                    maiorNvlVel[i] = "1";                
                }
            }
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(maiorNvlVel[j]);
            }
        }

        public static bool Nvl2(string QtdTartaruga, string NvlVelocidade)
        {
            int t = Convert.ToInt32(QtdTartaruga);
            string[] v = NvlVelocidade.Split(" ");
            for (int i = 0; i < t; i++)
            {
                if (int.Parse(v[i]) >= 10)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Nvl3(string QtdTartaruga, string NvlVelocidade)
        {
            int t = Convert.ToInt32(QtdTartaruga);
            string[] v = NvlVelocidade.Split(" ");
            for (int i = 0; i < t; i++)
            {
                if (int.Parse(v[i]) >= 20)
                {
                    return true;
                }
            }
                return false;
        }
    }
}