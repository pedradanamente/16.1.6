using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            /* Em um campeonato de futebol tem 5 times e cada time possui 11 jogadores. Faça um programa que receba a idade, o peso e a altura de cada um dos jogadores, calcule e mostre:
             * a) Quantidade de jogadores com idade inferior a 18
             * b) A média das idades dos jogadores de cada time
             * c) a média das alturas de todos os jogadores do campeonato
             */
            string escolheTime;
            int i, idade, media, idadeTotal, idadeInf18, preenchido;
            bool gremioBooleano, internacionalBooleano, juventudeBooleano, spBooleano, palmeirasBooleano;
            double altura, alturaSoma;

            gremioBooleano = false;
            internacionalBooleano = false;
            juventudeBooleano = false;
            spBooleano = false;
            palmeirasBooleano = false;
            idadeInf18=0;
            preenchido=0;
            alturaSoma = 0;
            altura = 0;

            while (preenchido != 5) {
                Console.WriteLine("Times: Grêmio, Internacional, Juventude, São Paulo, Palmeiras");
                Console.WriteLine("Escolha o Time:");
                escolheTime = Console.ReadLine();
                switch (escolheTime) {
                    case "Grêmio":
                        if (gremioBooleano == false) {
                            idadeTotal = 0;
                            for (i = 1; i <= 11; i++) {
                                Console.WriteLine("Digite a idade do {0} jogador", i);
                                idade = Convert.ToInt16(Console.ReadLine());
                                idadeTotal = idadeTotal + idade;
                                if (idade < 18) {
                                    idadeInf18++;
                                }
                                Console.WriteLine("Digite a altura do jogador {0}",i);
                                altura = Convert.ToDouble(Console.ReadLine());
                                alturaSoma = altura + alturaSoma;
                            }
                            media = idadeTotal / 11;
                            gremioBooleano = true;
                            preenchido++;
                            Console.WriteLine("B - A média de idade do grêmio é: {0}", media);
                            Console.ReadKey();
                        } else {
                            Console.WriteLine("Você já preencheu este Time!");
                        }
                        break;
                    case "Internacional":
                        if (internacionalBooleano == false) {
                            idadeTotal = 0;
                            for (i = 1; i <= 11; i++) {
                                Console.WriteLine("Digite a idade do {0} jogador", i);
                                idade = Convert.ToInt16(Console.ReadLine());
                                idadeTotal = idadeTotal + idade;
                                if (idade < 18) {
                                    idadeInf18++;
                                }
                                Console.WriteLine("Digite a altura do jogador {0}", i);
                                altura = Convert.ToDouble(Console.ReadLine());
                                alturaSoma = altura + alturaSoma;
                            }
                            media = idadeTotal / 11;
                            internacionalBooleano = true;
                            preenchido++;
                            Console.WriteLine("B - A média de idade do Internacional é: {0}", media);
                            Console.ReadKey();
                        } else {
                            Console.WriteLine("Você já preencheu este Time!");
                        }
                        break;
                    case "Juventude":
                        if (juventudeBooleano == false) {
                            idadeTotal = 0;
                            for (i = 1; i <= 11; i++) {
                                Console.WriteLine("Digite a idade do {0} jogador", i);
                                idade = Convert.ToInt16(Console.ReadLine());
                                idadeTotal = idadeTotal + idade;
                                if (idade < 18) {
                                    idadeInf18++;
                                }
                                Console.WriteLine("Digite a altura do jogador {0}", i);
                                altura = Convert.ToDouble(Console.ReadLine());
                                alturaSoma = altura + alturaSoma;
                            }
                            media = idadeTotal / 11;
                            juventudeBooleano = true;
                            preenchido++;
                            Console.WriteLine("B - A média de idade do Juventude é: {0}", media);
                            Console.ReadKey();
                        } else {
                            Console.WriteLine("Você já preencheu este Time!");
                        }
                        break;
                    case "São Paulo":
                        if (spBooleano == false) {
                            idadeTotal = 0;
                            for (i = 1; i <= 11; i++) {
                                Console.WriteLine("Digite a idade do {0} jogador", i);
                                idade = Convert.ToInt16(Console.ReadLine());
                                idadeTotal = idadeTotal + idade;
                                if (idade < 18) {
                                    idadeInf18++;
                                }
                                Console.WriteLine("Digite a altura do jogador {0}", i);
                                altura = Convert.ToDouble(Console.ReadLine());
                                alturaSoma = altura + alturaSoma;
                            }
                            media = idadeTotal / 11;
                            spBooleano = true;
                            preenchido++;
                            Console.WriteLine("B - A média de idade do São Paulo é: {0}", media);
                            Console.ReadKey();
                        } else {
                            Console.WriteLine("Você já preencheu este Time!");
                        }
                        break;
                    case "Palmeiras":
                        if (palmeirasBooleano == false) {
                            idadeTotal = 0;
                            for (i = 1; i <= 11; i++) {
                                Console.WriteLine("Digite a idade do {0} jogador", i);
                                idade = Convert.ToInt16(Console.ReadLine());
                                idadeTotal = idadeTotal + idade;
                                if (idade < 18) {
                                    idadeInf18++;
                                }
                                Console.WriteLine("Digite a altura do jogador {0}", i);
                                altura = Convert.ToDouble(Console.ReadLine());
                                alturaSoma = altura + alturaSoma;
                            }
                            media = idadeTotal / 11;
                            palmeirasBooleano = true;
                            preenchido++;
                            Console.WriteLine("B - A média de idade do Palmeiras é: {0}", media);
                            Console.ReadKey();
                        } else {
                            Console.WriteLine("Você já preencheu este Time!");
                        }
                        break;
                    default:
                        Console.WriteLine("Parâmetro Inválido");
                        break;
                }
            }
            if (preenchido == 5) {
                alturaSoma = alturaSoma / (5*11);
                Console.WriteLine("Você preencheu os 5 times, agora vamos aos resultados!");
                Console.WriteLine("A - Idades inferiores a 18 em todos times: {0}", idadeInf18);
                Console.WriteLine("C - A média de altura de todos jogadores é {0}", alturaSoma);
                Console.ReadKey();
            }
            Console.WriteLine("FIM");
            Console.ReadKey();
        }
    }
}
