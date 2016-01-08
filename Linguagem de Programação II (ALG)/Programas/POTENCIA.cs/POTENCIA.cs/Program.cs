using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXER02
{
    class Program
    {
        static void Main(string[] args) {
            string message, traducao = "";
            int newi, x, deslocamento;
            string[] alfabeto = new string[24];
            biblioteca(alfabeto);

            Console.WriteLine("Defina o deslocamento:");
            deslocamento = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite a string: \n");
            message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++) {
                if (i <= 24) {
                    newi = i;
                }
                else {
                    newi=i-24;
                }
                x = newi + deslocamento;
                Console.WriteLine("O indice do caracter {0} é {1}: ", message[newi], newi);
                Console.WriteLine("Sua letra no alfabeto é: {0}", alfabeto[x]);
                //traducao += "{0}", alfabeto[x];
                traducao += alfabeto[x];
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Traducao: {0}", traducao);
            Console.ReadKey();
        }

        static void biblioteca(string[] alfabeto) {
            alfabeto[0]="a";
            alfabeto[1]="b";
            alfabeto[2]="c";
            alfabeto[3]="d";
            alfabeto[4]="e";
            alfabeto[5]="f";
            alfabeto[6]="g";
            alfabeto[7]="h";
            alfabeto[8]="i";
            alfabeto[9]="j";
            alfabeto[10]="k";
            alfabeto[11]="l";
            alfabeto[10]="m";
            alfabeto[11]="n";
            alfabeto[12]="o";
            alfabeto[13]="p";
            alfabeto[14]="q";
            alfabeto[15]="r";
            alfabeto[16]="s";
            alfabeto[17]="t";
            alfabeto[18]="u";
            alfabeto[19]="v";
            alfabeto[20]="x";
            alfabeto[21]="w";
            alfabeto[22]="y";
            alfabeto[23]="z";
        }

    }
}