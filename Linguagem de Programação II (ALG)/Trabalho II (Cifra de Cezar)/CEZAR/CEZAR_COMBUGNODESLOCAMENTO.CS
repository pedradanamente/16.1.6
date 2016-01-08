using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXER03
{
    class Program
    {
        static void Main(string[] args) {
            //DECLARACAO DE VARIAVEIS
            string letra, message, traducao;
            int z, deslocamento;
            string[] alfabeto = new string[24];

            //CARREGA VETOR COM O ALFABETO
            biblioteca(alfabeto);

            do {
                //INICIO DO WHILE ONDE PERGUNTA O VALOR DO DESLOCAMENTO E A PALAVRA
                traducao = "";
                Console.WriteLine("Defina o numero de deslocamento:");
                deslocamento = Convert.ToInt16(Console.ReadLine());

                Console.Write("Digite a palavra: \n");
                message = Console.ReadLine();

                for (int i = 0; i < message.Length; i++) {
                    //CAPTURA LETRA A SUBSTITUIR
                    letra = message[i].ToString();

                    //PEGA INDICE FINAL REFERENTE AO DE SUBSTITUIR
                    int posicaoFinal = 0;
                    for (z = 0; z < alfabeto.Length; z++) {
                        if (alfabeto[z] == letra) {
                            posicaoFinal = z + deslocamento;
                            if (posicaoFinal <= 24) {
                                //CONCATENA A VARIAVEL COM AS LETRAS SUBSTITUITAS
                                traducao += alfabeto[posicaoFinal];
                            } else {
                                posicaoFinal = posicaoFinal - 24;
                                traducao += alfabeto[posicaoFinal];
                            }
                        }
                    }
                    Console.WriteLine("O indice do caracter ({0}) é {1}: ", message[i], z);
                    Console.WriteLine("Sua letra no alfabeto é: ({0})", alfabeto[posicaoFinal]);
                    Console.WriteLine("-------------------------");
                }

                //ESCREVE NA TELA A TRADUCAO
                Console.WriteLine("-------------------------");
                Console.WriteLine("Traducao: {0}", traducao);
                Console.WriteLine("-------------------------");
            } while (deslocamento >= 0);
            Console.ReadKey();
        }

        //BIBLIOTECA ONDE CADASTRA O ALFABETO NO VETOR ALFABETO
        static void biblioteca(string[] alfabeto) {
            alfabeto[0] = "a";
            alfabeto[1] = "b";
            alfabeto[2] = "c";
            alfabeto[3] = "d";
            alfabeto[4] = "e";
            alfabeto[5] = "f";
            alfabeto[6] = "g";
            alfabeto[7] = "h";
            alfabeto[8] = "i";
            alfabeto[9] = "j";
            alfabeto[10] = "k";
            alfabeto[11] = "l";
            alfabeto[10] = "m";
            alfabeto[11] = "n";
            alfabeto[12] = "o";
            alfabeto[13] = "p";
            alfabeto[14] = "q";
            alfabeto[15] = "r";
            alfabeto[16] = "s";
            alfabeto[17] = "t";
            alfabeto[18] = "u";
            alfabeto[19] = "v";
            alfabeto[20] = "x";
            alfabeto[21] = "w";
            alfabeto[22] = "y";
            alfabeto[23] = "z";
        }

    }
}