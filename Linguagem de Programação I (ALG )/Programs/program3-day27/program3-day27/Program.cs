using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            /*Foi realizada uma pesquisa com os 30 moradores de um edifício comercial para otimizar a utilização dos
elevadores. O edifício possui quatro elevadores (a, b, c, d) que são usados livremente. Os usuários
responderam as seguintes questões:
1. qual o elevador utilizado (a, b, c, d)?
2. qual o turno, seguindo os códigos: manhã, tarde e noite (m, t, n)?
Construa um programa que cadastre as respostas dos moradores e no final informe o elevador mais utilizado
e o turno em que os elevadores são mais utilizados. */
            int x, manha, tarde, noite, a, b, c, d;
            string turno, elevadorUtilizado, turnoMais, elevadorMais;
            a=0;b=0;c=0;d=0;
            manha=0;tarde=0;noite=0;
            elevadorMais = "Indefinido";
            turnoMais = "Indefinido";
            x = 1;
            while (x <= 30) {
                Console.WriteLine("[{0}] Qual elevador utilizado? (a, b, c, d)?",x);
                elevadorUtilizado = Console.ReadLine();
                Console.WriteLine("[{0}] Qual turno... manhã, tarde ou noite ?",x);
                turno = Console.ReadLine();
                switch (elevadorUtilizado) {
                    case "a":
                        a++;
                        if ((a > b) && (a > c) && (a > d)) {
                            elevadorMais = "A";
                        }
                        break;
                    case "b":
                        b++;
                        if ((b > a) && (b > c) && (b > d)) {
                            elevadorMais = "B";
                        }
                        break;
                    case "c":
                        c++;
                        if ((c > a) && (c > b) && (c > d)) {
                            elevadorMais = "C";
                        }
                        break;
                    case "d":
                        d++;
                        if ((d > a) && (d > b) && (d > c)) {
                            elevadorMais = "D";
                        }
                        break;
                    default:
                        Console.WriteLine("Parâmetro Inválido!");
                        Console.ReadKey();
                        break;
                }
                switch (turno) {
                    case "manhã":
                        manha++;
                        if ((manha > tarde) && (manha > noite)) {
                            turnoMais = "Manhã";
                        }
                        break;
                    case "tarde":
                        tarde++;
                        if ((tarde > manha) && (tarde > noite)) {
                            turnoMais = "Tarde";
                        }
                        break;
                    case "noite":
                        noite++;
                        if ((noite > tarde) && (noite > manha)) {
                            turnoMais = "Noite";
                        }
                        break;
                    default:
                        Console.WriteLine("Parâmetro Inválido!");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("Pressione uma tecla para continuar.");
                Console.ReadKey();
                x++;
            }
            Console.WriteLine("O elevador mais utilizado é: {0}", elevadorMais);
            Console.WriteLine("O turno mais utilizado é: {0}", turnoMais);
            Console.ReadKey();
        }
    }
}
