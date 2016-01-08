using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            /*
             * 3) Escrever um algoritmo que lê 4 valores: I, A, B e C. Se I for igual a 1 então calcular a média aritmética de A, B e C
e escrever esta média; se I for igual a 2 somar os 3 valores atribuindo este valor a uma variável qualquer e
escrevendo esta soma; se I for igual a 3 fazer um teste para saber se B é par, se é par escrever a mensagem e o
valor, caso contrário escrever que é ímpar
             * */
            string I;
            int A, B, C, SOMA;
            double media;
            do {
                Console.WriteLine("Digite o valor de I: 1, 2 ou 3");
                I = Console.ReadLine();
            } while ( I != "3" && I != "2" && I != "1" );
            Console.WriteLine("Digite primeiro numero:");
            A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite segundo numero:");
            B = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite terceiro numero:");
            C = Convert.ToInt16(Console.ReadLine());
            switch (I) {
                case "1":
                    media = (double)(A+B+C)/3;
                    Console.WriteLine("Media eh: {0}",media);
                    break;
                case "2":
                    SOMA=A+B+C;
                    Console.WriteLine("Soma eh: {0}", SOMA);
                    break;
                case "3":
                    if (B%2==0) { Console.WriteLine("{0} EH PAR",B); } else { Console.WriteLine("B É IMPAR"); }
                    break;
                default:
                    Console.WriteLine("PARAMETRO INVALIDO");
                    break;
            }
            Console.ReadKey();
        }
    }
}
