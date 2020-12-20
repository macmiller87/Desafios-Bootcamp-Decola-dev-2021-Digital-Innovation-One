/*
Desafio
O rodízio de veículos de Bravoos é uma restrição à circulação de veículos na cidade. Com o propósito de melhorar as condições ambientais reduzindo a carga de poluentes na atmosfera,incluindo na região de Westeros, se consolidou como um instrumento para reduzir congestionamentos nas principais vias da cidade, nos horários de maior movimento. Nas ruas delimitadoras não é permitido o tráfego de cavalos e carruagens que estejam dentro da restrição. Há uma escala que determina em quais dias da semana quais veículos não podem circular. Essa escala é regida pelo último dígito da placa do animal, sendo:

Segunda-feira, digito final da placa 1 e 2
Terça-feira, digito final da placa 3 e 4
Quarta-feira, digito final da placa 5 e 6
Quinta-feira, digito final da placa 7 e 8
Sexta-feira, digito final da placa 9 e 0
Os motoristas que são flagrados violando a restrição de circulação são autuados com multa de 4 galinhas e condenados a passar 1 semana na Muralha.

Entrada
A primeira linha de entrada representa a quantidade de testes N (0 <= N < 1000) que deverão ser considerados. As demais entradas são cadeia de caracteres com tamanho máximo S (1 <= S <= 100) que representam cada placa que deverá ser analisada, de tal forma que, cada placa fique em uma única linha de entrada. O formato esperado para uma placa veicular válida em Bravoos é "AAA-9999", tal que A é um caracter válido em [A-Z], e 9 um dígito numérico válido em [0-9].

Saída
O conjunto de valores válidos como saída são: SEGUNDA, TERCA, QUARTA, QUINTA e SEXTA, de acordo com a tabela de restrições predefinida, e FALHA caso a placa não apresente o padrão definido.
*/

using System;
using System.Linq;


class MinhaClasse {
    public static void Main (string[] args) {
        int quantidadeTestes = int.Parse(Console.ReadLine());
        string[] Placas = new string[quantidadeTestes];


        for (int i = 0; i < quantidadeTestes; i++) {
            Placas[i] = Console.ReadLine();
        }


        for (int i = 0; i < quantidadeTestes; i++) {
        if (ValidarPlaca(Placas[i]) == true) {
            int dig = PegarUltimo(Placas[i]);
            string rod = CalcularRod(dig);
            Console.WriteLine(rod);
        } else {
            Console.WriteLine("FALHA");
        }
        }
    }


    public static bool ValidarPlaca(string placa) { // validar formato "AAA-9999"
        string[] campos = placa.Split("-");
        if (campos.Length == 2) {
            string letras = campos[0];
            string nums = campos[1];
            if (letras.Length == 3 && nums.Length == 4) {
                if (letras.All(char.IsLetter) && letras.All(char.IsUpper) && nums.All(char.IsDigit)) {
                    return true;
                } else {return false;}
            } else {return false;}
        } else {return false;}
    }


    public static int PegarUltimo(string placa) {
        return int.Parse(placa.Substring(placa.Length -1));
    }


    public static string CalcularRod(int digito) {
        if (digito == 1 || digito == 2) {
            return "SEGUNDA";
        } else if (digito == 3 || digito == 4) {
            return "TERCA";
        } else if (digito == 5 || digito == 6) {
            return "QUARTA";
        } else if (digito == 7 || digito == 8) {
            return "QUINTA";
        } else if (digito == 9 || digito == 0) {
            return "SEXTA";
        } else {
            return "FALHA";
        }
    }
}