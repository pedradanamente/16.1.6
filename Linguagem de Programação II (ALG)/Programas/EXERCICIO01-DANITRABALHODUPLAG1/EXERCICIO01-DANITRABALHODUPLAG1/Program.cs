using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int LIN = 3, COL = 3, TAM = 5, JOGO = 2;
            int x, y, z, w, a, b, contV = 0, lc = 0, controleT = 0, controle1 = 0, controle2 = 0, controle3 = 0,
            controle4 = 0, controle5 = 0, controle6 = 0, cont1 = 0, cont2 = 2, cont3 = 0, cont4 = 0, cont5 = 2, cont6 = 0,
            controleH1 = 0, controleH2 = 0, controleH3 = 0, controleH4 = 0, controleH5 = 0, controleH6 = 0,
            controleV1 = 0, controleV2 = 0, controleV3 = 0, controleV4 = 0, controleV5 = 0, controleV6 = 0;

            string[,] matriz = new string[LIN, COL];
            string[] vetor = new string[TAM];

            Console.WriteLine("JOGO DA VELHA");

            for (x = 0; x < LIN; x++) {
                for (y = 0; y < COL; y++) {
                    matriz[x, y] = ".";
                }
            }

            escreve(LIN, COL, matriz);

            for (z = 0; z < JOGO; z++) {
                do {
                    for (w = 0; w < 9; w++) {
                        //Escreve as linas e colunas
                        if (w % 2 == 0) {
                            lc = 1;
                            linCon(matriz, lc, LIN, COL);

                        } else {
                            lc = 2;
                            linCon(matriz, lc, LIN, COL);
                        }

                        escreve(LIN, COL, matriz);

                        //teste X
                        if (w >= 4) {
                            for (a = 0; a < LIN; a++) {
                                for (b = 0; b < COL; b++) {
                                    //teste diagonal principal X
                                    if (b == cont1) {
                                        if (matriz[a, b] == "X") {
                                            controle1++;
                                        }
                                    }
                                    //teste diagonal secundaria X
                                    if (b == cont2) {
                                        if (matriz[a, b] == "X") {
                                            controle2++;
                                        }
                                    }
                                    //teste linha X
                                    if (a == cont3) {
                                        if (matriz[a, b] == "X") {
                                            if (a == 0) {
                                                controleH1++;
                                            } else if (a == 1) {
                                                controleH2++;
                                            } else if (a == 2) {
                                                controleH3++;
                                            }
                                        }
                                    }

                                }
                                cont1++;
                                cont2--;
                                cont3++;
                            }

                            //teste coluna X
                            for (a = 0; a < LIN; a++) {
                                for (b = 0; b < COL; b++) {
                                    if (matriz[b, a] == "X") {
                                        if (a == 0) {
                                            controleV1++;
                                        } else if (a == 1) {
                                            controleV2++;
                                        } else if (a == 2) {
                                            controleV3++;
                                        }
                                    }
                                }
                            }

                            if (controle1 == 3 || controle2 == 3 || controle3 == 3 || controleH1 == 3 || controleH2 == 3 || controleH3 == 3 || controleV1 == 3 || controleV2 == 3 || controleV3 == 3) {
                                controleT = 1;
                            }
                            controle1 = 0;
                            controle2 = 0;
                            controle3 = 0;
                            cont1 = 0;
                            cont2 = 2;
                            cont3 = 0;
                            controleH1 = 0;
                            controleH2 = 0;
                            controleH3 = 0;
                            controleV1 = 0;
                            controleV2 = 0;
                            controleV3 = 0;

                        }

                        //teste 0
                        if (controleT != 1) {
                            if (w >= 4) {
                                for (a = 0; a < LIN; a++) {
                                    for (b = 0; b < COL; b++) {
                                        //teste diagonal principal 0
                                        if (b == cont4) {
                                            if (matriz[a, b] == "0") {
                                                controle4++;
                                            }
                                        }
                                        //teste diagonal secundaria 0
                                        if (b == cont5) {
                                            if (matriz[a, b] == "0") {
                                                controle5++;
                                            }
                                        }
                                        //teste linha 0
                                        if (a == cont6) {
                                            if (matriz[a, b] == "0") {
                                                if (a == 0) {
                                                    controleH4++;
                                                } else if (a == 1) {
                                                    controleH5++;
                                                } else if (a == 2) {
                                                    controleH6++;
                                                }
                                            }
                                        }

                                    }
                                    cont4++;
                                    cont5--;
                                    cont6++;
                                }

                                //teste coluna 0
                                for (a = 0; a < LIN; a++) {
                                    for (b = 0; b < COL; b++) {
                                        if (matriz[b, a] == "0") {
                                            if (a == 0) {
                                                controleV4++;
                                            } else if (a == 1) {
                                                controleV5++;
                                            } else if (a == 2) {
                                                controleV6++;
                                            }
                                        }
                                    }
                                }


                                if (controle4 == 3 || controle5 == 3 || controle6 == 3 || controleH4 == 3 || controleH5 == 3 || controleH6 == 3 || controleV4 == 3 || controleV5 == 3 || controleV6 == 3) {
                                    controleT = 2;
                                }

                                controle4 = 0;
                                controle5 = 0;
                                controle6 = 0;
                                cont4 = 0;
                                cont5 = 2;
                                cont6 = 0;
                                controleH4 = 0;
                                controleH5 = 0;
                                controleH6 = 0;
                                controleV4 = 0;
                                controleV5 = 0;
                                controleV6 = 0;
                            }
                        }

                        if (controleT == 1) {
                            vetor[contV] = "X";
                            Console.WriteLine("Vencedor da Rodada " + z + " é o jogador X");
                            contV++;
                            w = 10;
                            for (x = 0; x < LIN; x++) {
                                for (y = 0; y < COL; y++) {
                                    matriz[x, y] = ".";
                                }
                            }
                        } else if (controleT == 2) {
                            vetor[contV] = "0";
                            Console.WriteLine("Vencedor da Rodada " + z + " é o jogador 0");
                            contV++;
                            w = 10;
                            for (x = 0; x < LIN; x++) {
                                for (y = 0; y < COL; y++) {
                                    matriz[x, y] = ".";
                                }
                            }
                        }

                        if (w == 8 && controleT == 0) {
                            controleT = 3;
                        }

                        if (controleT == 3) {
                            vetor[contV] = ".";
                            Console.WriteLine("Rodada " + z + " terminou em empate");
                            contV++;
                            for (x = 0; x < LIN; x++) {
                                for (y = 0; y < COL; y++) {
                                    matriz[x, y] = ".";
                                }
                            }
                        }

                    }
                } while (controleT == 0);

                controle1 = 0;
                controle2 = 0;
                controle3 = 0;
                cont1 = 0;
                cont2 = 2;
                cont3 = 0;
                controleH1 = 0;
                controleH2 = 0;
                controleH3 = 0;
                controleV1 = 0;
                controleV2 = 0;
                controleV3 = 0;

                controle4 = 0;
                controle5 = 0;
                controle6 = 0;
                cont4 = 0;
                cont5 = 2;
                cont6 = 0;
                controleH4 = 0;
                controleH5 = 0;
                controleH6 = 0;
                controleV4 = 0;
                controleV5 = 0;
                controleV6 = 0;

                controleT = 0;

                for (x = 0; x < LIN; x++) {
                    for (y = 0; y < COL; y++) {
                        matriz[x, y] = ".";
                    }
                }
            }

            escreveV(vetor, JOGO);

            Console.ReadKey();
        }



        //Linhas e colunas
        static void linCon(string[,] matriz, int lc, int LIN, int COL) {
            int l = 0, c = 0;
            if (lc == 1) {
                Console.WriteLine("Jogador X");
            } else if (lc == 2) {
                Console.WriteLine("Jogador 0");
            }

            Console.WriteLine("Digite a Linha que quer jogar: ");
            l = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a Coluna que quer jogar: ");
            c = Convert.ToInt16(Console.ReadLine());
            while ((l > 2 && c > 2) || (l > 2 || c > 2)) {
                Console.WriteLine("Erro! Digite novamente a Linha que quer jogar: ");
                l = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Erro! Digite novamente a Coluna que quer jogar: ");
                c = Convert.ToInt16(Console.ReadLine());
            }

            while (matriz[l, c] == "X" || matriz[l, c] == "0") {
                Console.WriteLine("Erro! Digite novamente a Linha que quer jogar: ");
                l = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Erro! Digite novamente a Coluna que quer jogar: ");
                c = Convert.ToInt16(Console.ReadLine());
                while ((l > 2 && c > 2) || (l > 2 || c > 2)) {
                    Console.WriteLine("Erro! Digite novamente a Linha que quer jogar: ");
                    l = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Erro! Digite novamente a Coluna que quer jogar: ");
                    c = Convert.ToInt16(Console.ReadLine());
                }
            }

            if (lc == 1) {
                matriz[l, c] = "X";
            } else if (lc == 2) {
                matriz[l, c] = "0";
            }


        }


        //escreve a matriz
        static void escreve(int LIN, int COL, string[,] matriz) {
            int x, y;
            for (x = 0; x < LIN; x++) {
                for (y = 0; y < COL; y++) {
                    Console.Write(matriz[x, y] + "\t");

                }
                Console.WriteLine("\n");
            }
        }

        //escreve a matriz com as vitória e o melhor jogador
        static void escreveV(string[] vetor, int JOGO) {
            int x, cM1 = 0, cM2 = 0;

            Console.WriteLine("Vencedores das Partidas");
            for (x = 0; x < JOGO; x++) {
                Console.Write(vetor[x] + "\t");

                if (vetor[x] == "X") {
                    cM1++;
                } else if (vetor[x] == "0") {
                    cM2++;
                }
            }
            if (cM1 > cM2) {
                Console.WriteLine("\n" + "Melhor de 5: Jogador X");
            } else {
                Console.WriteLine("\n" + "Melhor de 5: Jogador 0");
            }
        }

    }
}