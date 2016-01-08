using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //ADAPTADO DE ANDRÉ SILVEIRA MACHADO
        static void Main(string[] args) {
            double RESPOSTA_F;
            decimal preco, RESPOSTA_B, precoTotal, RESPOSTA_C;
            string cor, gola, tamanho, RESPOSTA_E;
            int RESPOSTA_A, CONTADOR, QUANTIDADE, RESPOSTA_D, C_LARANJA, C_AZUL, C_BRANCA, TOTAL, TAMANHO_M;

            RESPOSTA_A = 0;
            RESPOSTA_D = 0;
            CONTADOR = 0;
            QUANTIDADE = 0;
            precoTotal = 0;
            C_LARANJA = 0;
            C_AZUL = 0;
            C_BRANCA = 0;
            TOTAL = 0;
            TAMANHO_M = 0;
            RESPOSTA_C = 0;
            RESPOSTA_B = 0;
            RESPOSTA_E = "VALOR NULO";

            Console.WriteLine("Informe o preco da camiseta:");
            preco = Convert.ToDecimal(Console.ReadLine());
            while (preco != 0) {
                do {
                    Console.WriteLine("Informe o tamanho (P, M, G, XG):");
                    tamanho = Console.ReadLine();
                } while (tamanho != "P" && tamanho != "M" && tamanho != "G" && tamanho != "XG");

                do {
                    Console.WriteLine("Informe a cor (BRANCA, AZUL OU LARANJA):");
                    cor = Console.ReadLine();
                } while (cor != "BRANCA" && cor != "AZUL" && cor != "LARANJA");
                do {
                    Console.WriteLine("Informe o tipo de gola (REDONDA OU V):");
                    gola = Console.ReadLine();
                } while (gola != "REDONDA" && gola != "V");

                //RESPOSTA DA LETRA A PROCESSSA AQUI:
                if ((cor == "AZUL") && (tamanho == "P")) {
                    RESPOSTA_A++;
                }

                //RESPOSTA DA LETRA B PROCESSSA AQUI:
                if ((CONTADOR == 0) && (cor == "BRANCA")) {
                    RESPOSTA_B = preco;
                    CONTADOR++;
                } else if ((CONTADOR > 0) && (cor == "BRANCA")) {
                    if (preco < RESPOSTA_B) {
                        RESPOSTA_B = preco;
                    }
                }

                //RESPOSTA DA LETRA C PROCESSA AQUI:
                if ((gola == "REDONDA") && (tamanho == "G")) {
                    QUANTIDADE++;
                    precoTotal = precoTotal + preco;
                }

                //RESPOSTA DA LETRA D PROCESSA AQUI:
                if ((preco >= 30) && (preco <= 40) && (cor == "LARANJA")) {
                    RESPOSTA_D++;
                }

                //RESPOSTA DA LETRA E PROCESSA AQUI:
                if (cor == "BRANCA") {
                    C_BRANCA++;
                } else if (cor == "AZUL") {
                    C_AZUL++;
                } else if (cor == "LARANJA") {
                    C_LARANJA++;
                }

                //RESPOSTA DA LETRA F PROCESSA AQUI:
                TOTAL++;
                if (tamanho == "M") {
                    TAMANHO_M++;
                }
                Console.WriteLine("DIGITE O PRECO DA OUTRA CAMISETA OU ZERO PARA DAR FIM:");
                preco = Convert.ToDecimal(Console.ReadLine());
            }
            if (TOTAL != 0) {
                //RESPOSTA DA LETRA C PROCESSA AQUI:
                if (QUANTIDADE != 0) {
                    RESPOSTA_C = precoTotal / QUANTIDADE;
                }
                //RESPOSTA DA LETRA E PROCESSA AQUI:
                if ((C_BRANCA > C_AZUL) && (C_BRANCA > C_LARANJA)) {
                    RESPOSTA_E = "BRANCA";
                } else if ((C_AZUL > C_BRANCA) && (C_AZUL > C_LARANJA)) {
                    RESPOSTA_E = "AZUL";
                } else if ((C_LARANJA > C_BRANCA) && (C_LARANJA > C_AZUL)) {
                    RESPOSTA_E = "AZUL";
                } else {
                    RESPOSTA_E = "TODAS AS CORES POSSUEM A MESMA QUANTIDADE";
                }

                //RESPOSTA DA LETRA F PROCESSA AQUI:
                RESPOSTA_F = (double)(100 * TAMANHO_M) / TOTAL;

                //ESCREVENDO AS RESPOSTAS:
                Console.WriteLine("RESPOSTA A: {0}, B: {1}, C: {2}, D: {3} , E: {4}, F: {5}", RESPOSTA_A, RESPOSTA_B, RESPOSTA_C, RESPOSTA_D, RESPOSTA_E, RESPOSTA_F);
            }
            Console.WriteLine("Tecle algo para sair");
            Console.ReadKey();
        }
    }
}
