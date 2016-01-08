using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /* ============================================================= */
        /* RESETA O JOGO
         * ============================================================= */
        static void reseta(int TL, int TC, string[,] velhinha){
            for (int i = 0; i < TL; i++) {
                for (int j = 0; j < TC; j++) {
                    velhinha[i, j] = "0";
                }
            }
        }
        /* ============================================================= */
        /* TELA DO JOGO DA VELHA
         * ============================================================= */
        static void tela(string[,] velhinha, int TL, int TC) {
            int i, j;
            Console.WriteLine("********************");
            for (i = 0; i < TL; i++) {
                for (j = 0; j < TC; j++) {
                    Console.Write("{0} \t", velhinha[i, j]);

                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("********************");
        }
        /* ============================================================== */
        /* CADASTRA JOGADOR
         * ============================================================== */
        static string CADASTRA(int numero){
            string r;
            Console.WriteLine("Nome do jogador {0} para cadastro:", numero);
            r = Console.ReadLine();
            return r;
        }
        /* ============================================================== */
        /* FUNCAO DIGITE A LINHA
         * ============================================================== */
        static int Linha(int TL) {
            int r;
            Console.Write("Escolha uma linha: ");
            r = Convert.ToInt16(Console.ReadLine());
            while (r > TL - 1) {
                Console.WriteLine("[Warning] Linha excedida! Use de 0 até {0}", TL-1);
                Console.Write("Escolha uma linha: ");
                r = Convert.ToInt16(Console.ReadLine());
            }
            return r;
        }
        /* ============================================================== */
        /* FUNCAO DIGITE A COLUNA
         * ============================================================== */
        static int Coluna(int TC) {
            int r;
            Console.Write("Escolha uma coluna: ");
            r = Convert.ToInt16(Console.ReadLine());
            while (r > TC - 1) {
                Console.WriteLine("[Warning] Coluna excedida! Use de 0 até {0}", TC-1);
                Console.Write("Escolha uma linha: ");
                r = Convert.ToInt16(Console.ReadLine());
            }
            return r;
        }
        /* ============================================================== */
        /* FUNCAO DE JOGAR
         * ============================================================== */
        static void JOGAR(string[,] velhinha, string x, int TL, int TC, string player1, string player2) {
            int l = 0, c = 0;
            string player;
            if (x == "1") {
                player = player1;
            } else {
                player = player2;
            }
            Console.WriteLine("SUA VEZ JOGADOR: {0}", player);
            Console.WriteLine("============================");
            l = Linha(TL);
            c = Coluna(TC);
            while (velhinha[l, c] == "1" || velhinha[l, c] == "2") {
                Console.WriteLine("[Warning] Posição ocupada! Tente novamente.");
                l = Linha(TL);
                c = Coluna(TC);
            }
            velhinha[l, c] = x;
        }
        /* ==================================================================================== */
        /* VERIFICA SE HA ALGUM ELEMENTO COM VALOR 3 NO VETOR DE PREENCHIMENTO DO JOGO DA VELHA
         * ==================================================================================== */
        static int foriax(int[,,] VHD) {
        //ESTOU USANDO ESTE FOREACH PARA FACILITAR E SIMPLIFICAR A LEITURA DO CÓDIGO
            int r = 0;
            foreach(int elemento in VHD){
                if (elemento == 3) {
                    r = 1;
                }
            }
            return r;
        }
        /* ============================================================== */
        /* RETORNA A VARIAVEL X COMO INTEIRA SE JOGADOR ESCOLHIDO VENCEU
        * =============================================================== */
        static int verificacao(string x, int jo, string[,] velhinha, int TL, int TC) {
            int r = 0, quadradomagico, i, j;
            int[] contador = new int[4];
            int[,,] VHD = new int[4,4,4];

            //TESTE DE PREENCHIMENTO DA LINHA/COLUNA
            if (jo > 3) {
                for (i = 0; i < TL; i++) {
                    for (j = 0; j < TC; j++) {
                        //TESTE DA DIAGONAL PRINCIPAL
                        if (j == contador[1]) {
                            if (velhinha[i, j] == x) {
                                VHD[0,0,1]++;
                            }
                        }
                        //TESTE DA DIAGONAL SECUNDARIA
                        if (j == contador[2]) {
                            if (velhinha[i, j] == x) {
                                VHD[0,0,2]++;
                            }
                        }
                        //TESTE DE LINHA HORIZONTAL
                        if (i == contador[3]) {
                            if (velhinha[i, j] == x) {
                                if (i == 0) {
                                    VHD[0,1,0]++;
                                } else if (i == 1) {
                                    VHD[0,2,0]++;
                                } else if (i == 2) {
                                    VHD[0,3,0]++;
                                }
                            }
                        }
                    }
                    contador[1]++;
                    contador[2]--;
                    contador[3]++;
                }
                //TESTE DE COLUNA VERTICAL
                for (i = 0; i < TL; i++) {
                    for (j = 0; j < TC; j++) {
                        if (velhinha[j, i] == x) {
                            if (i == 0) {
                                VHD[1,0,0]++;
                            } else if (i == 1) {
                                VHD[2,0,0]++;
                            } else if (i == 2) {
                                VHD[3,0,0]++;
                            }
                        }
                    }
                }
                //PROCURA SE EXISTE UM VENCEDOR NO JOGO
                quadradomagico = foriax(VHD);
                if (quadradomagico == 1) {
                    if (x == "1") {
                        r = 1;
                    } else if (x == "2") {
                        r = 2;
                    }
                }
                contador[1] = 0;
                contador[2] = 2;
                contador[3] = 0;
            }
            return r;
        }
        /* ============================================================== */
        /* VERIFICACAO FINAL DA RODADA REFERENTE A VITORIA OU EMPATE
        * =============================================================== */
        static int final(int v, string player1, string player2, int TL, int TC, string[,] velhinha, string[] ROUNDS, int p) {
            int r = 0;
            string player = "NULL";
            if (v == 1) {
                ROUNDS[p-1] = "1";
                player = player1;
                r = 1;
            } else if (v == 2) {
                player = player2;
                ROUNDS[p-1] = "2";
                r = 1;
            }
            else if (v == 3) {
                ROUNDS[p - 1] = "2";
                Console.WriteLine("***********************************");
                Console.WriteLine("PARTIDA {0} FINALIZOU COM EMPATE", p);
                Console.WriteLine("***********************************");
                r = 1;
            }
            if ((v == 1) || (v == 2)) {
                Console.WriteLine("***********************************");
                Console.WriteLine("JOGADOR VENCEDOR DA PARTIDA {0}: {1}", p, player);
                Console.WriteLine("***********************************");
            }
            return r;
        }
        /* ============================================================== */
        /* ESTATISTICAS E MELHOR DE 5
        * =============================================================== */
        static void MD5(string[] ROUNDS, string player1, string player2) {
            int p1 = 0, p2 = 0;
            string player = "NULL";
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("ESTATÍSTICAS DA MD5...............................");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("VENCEDORES: ");
            for (int i = 0; i < 5; i++) {
                Console.Write("[{0}] ", ROUNDS[i]);
                if (ROUNDS[i] == "1") {
                    p1++;
                }else 
                {
                    p2++;
                }
            }
            if (p2 < p1) {
                player = player2;
            } else {
                player = player1;
            }
            Console.WriteLine("");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("NOME DO VENCEDOR DA MD5: {0}", player);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        /* ============================================================== */
        /* INICIO DE UM NOVO JOGO
        * =============================================================== */
        static void iniciar(int p, int TL, int TC, string[,] velhinha, string player1, string player2, string[] ROUNDS) {
            int b = 0, v = 0;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("NOVO JOGO INICIADO!");
            Console.WriteLine("PARTIDA NUMERO: {0}, COM TOTAL DE 5", p);
            Console.WriteLine("------------------------------------------");
            reseta(TL, TC, velhinha);
            tela(velhinha, TL, TC);
            do {
                for (int jo = 1; jo <= 10; jo++) {
                    if (jo % 2 == 0) {
                        JOGAR(velhinha, "1", TL, TC, player1, player2);
                        v = verificacao("1", jo, velhinha, TL, TC);
                    } else {
                        JOGAR(velhinha, "2", TL, TC, player1, player2);
                        v = verificacao("2", jo, velhinha, TL, TC);
                    }
                    tela(velhinha, TL, TC);
                    //LEVA A POSSIBILIDADE DE UM VENCEDOR NA VARIAVEL V
                    b = final(v, player1, player2, TL, TC, velhinha, ROUNDS, p);
                    //SE ACABAR AS PARTIDAS ENTAO DA UM BREAK E SAI DO FOR FORÇADO
                    if (b == 1) {
                        b = 0;
                        break;
                    }
                }
            //ENQUANTO NAO TIVER VENCEDOR O JOGO CONTINUA
            } while (v == 0);
        }
        /* ============================================================== */
        /* FUNCAO PRINCIPAL //MAIN
        * =============================================================== */
        static void Main(string[] args) {
            const int TL = 3, TC = 3;
            string[,] velhinha = new string[TL, TC];
            string[] ROUNDS = new string[5];
            string player1, player2;
            Console.WriteLine("JOGUINHO DA VELHA");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Good Luck! 2014 ALGORITMOS II, DANIELA SCHERER");
            Console.WriteLine("GRUPO: ANDRE MACHADO, VINICIUS WEISE");
            Console.WriteLine("-------------------------------------------------");
            player1 = CADASTRA(1);
            player2 = CADASTRA(2);
            for (int p = 1; p <= 5; p++) {
                iniciar(p, TL, TC, velhinha, player1, player2, ROUNDS);
            }
            MD5(ROUNDS, player1, player2);
            Console.ReadKey();
        }
    }
}