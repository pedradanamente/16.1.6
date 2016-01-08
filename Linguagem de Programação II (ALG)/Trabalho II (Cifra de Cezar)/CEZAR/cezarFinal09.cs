using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cezarFinal09
//ANDRE SILVEIRA MACHADO
{
    class Program
    {
        static void Main(string[] args) {
            string[] book = new string[26];
            string message, Traducao;
            int j, deslocamento, posicaoFinal = 0;
            libs(book);
            do {
                Traducao = "";
                do {
                    Console.Write("DESLOCAMENTO (DE 0 A 30): ");
                    deslocamento = Convert.ToInt16(Console.ReadLine());
                } while (deslocamento > 30 || deslocamento < 0);
                Console.Write("DIGITE A PALAVRA A CRIPTOGRAFAR: \n");
                message = Console.ReadLine().ToLower();
                for (int i = 0; i < message.Length; i++) {
                    for (j = 0; j < book.Length; j++) {
                        if (book[j] == message[i].ToString()) {
                            posicaoFinal = j + deslocamento;
                            if (posicaoFinal > book.Length) {
                                posicaoFinal = posicaoFinal - book.Length;
                            }
                            Traducao += book[posicaoFinal];
                        }
                    }
                }
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("PALAVRA CRIPTOGRAFADA: {0}", Traducao);
                Console.WriteLine("-----------------------------------------------");
            } while (deslocamento >= 0);
            Console.ReadKey();
        }
        static void libs(string[] book) {
            book[0] = "a";
            book[1] = "b";
            book[2] = "c";
            book[3] = "d";
            book[4] = "e";
            book[5] = "f";
            book[6] = "g";
            book[7] = "h";
            book[8] = "i";
            book[9] = "j";
            book[10] = "k";
            book[11] = "l";
            book[12] = "m";
            book[13] = "n";
            book[14] = "o";
            book[15] = "p";
            book[16] = "q";
            book[17] = "r";
            book[18] = "s";
            book[19] = "t";
            book[20] = "u";
            book[21] = "v";
            book[22] = "x";
            book[23] = "w";
            book[24] = "y";
            book[25] = "z";
        }

    }
}