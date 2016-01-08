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
            string x, message, traducao;
            int indice, deslocamento;
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

                //FAZ A BUSCA DOS INDICES DA STRING PARA FAZER PESQUISA NA BIBLIOTECA
                for (int i = 0; i < message.Length; i++) {
                    if (i <= 24) {
                        indice = i;
                    } else {
                        indice = i - 24;
                    }

                    //FAZ PESQUISA NA BIBLIOTECA E RETORNA LETRA SUBSTITUTA DA LETRA DO LOOP ATUAL
                    x = pesquisa(alfabeto, indice, deslocamento);

                    //CONCATENA A VARIAVEL COM AS LETRAS SUBSTITUITAS
                    traducao += x;

                    //ESCREVE NA TELA DADOS ENCONTRADOS
                    Console.WriteLine("O indice do caracter ({0}) é {1}: ", message[i], i);
                    Console.WriteLine("Sua letra no alfabeto é: ({0})", x);
                    Console.WriteLine("-------------------------");
                }

                //ESCREVE NA TELA A TRADUCAO
                Console.WriteLine("-------------------------");
                Console.WriteLine("Traducao: {0}", traducao);
                Console.WriteLine("-------------------------");
            } while (deslocamento >= 0);
            Console.ReadKey();
        }

        //FUNCAO DE PESQUISA QUE RETORNA LETRA SUBSTITUTA
        static string pesquisa(string[] alfabeto, int indice, int deslocamento) {
            string r;
            int x;

            //ATRIBUI INDICE DA LETRA ATUAL COM A SOMA DO VALOR DO DESLOCAMENTO
            x = indice + deslocamento;
            r = alfabeto[x];
            return r;
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