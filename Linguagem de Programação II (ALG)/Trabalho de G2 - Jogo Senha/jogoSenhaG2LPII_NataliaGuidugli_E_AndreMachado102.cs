using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /* ########################################################################## *
         * NATALIA GUIDUGLI E ANDRE MACHADO                                           *
         * ########################################################################## */

        //OBSERVACAO: A SENHA APARECE NA PRIMEIRA TELA DO JOGO, ANOTAR PARA FAZER O TESTE!

        /* -------------------------------------------------------------------------- *
         * PRINCIPAL                                                                  *
         * -------------------------------------------------------------------------- */
        unsafe static void Main(string[] args) {
            const int T = 6, TL = 10, TC = 8, TS = 4;
            string[] TENTATIVASDIGITADAS = new string[TS];
            string[] OP = new string[T];
            string[,] tela = new string[TL, TC];
            string[] passwd = new string[TS];
            int Fatality = 0, Tentativas = 0, contador = 0;
            int RESPOSTA1 = 0, RESPOSTA2 = 0, RESPOSTA3 = 0;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            for (int i = 0; i < T; i++) //CARREGA OPCOES DE RESPOSTAS EM NUMEROS DENTRO DE UM VETOR
                OP[i] = (i + 1).ToString();
            gerarSenha(passwd, TS, OP); //GERA UMA SENHA PARA O ROUND
            Console.Write("\n\tInforme seu nome: ");
            string nome = Console.ReadLine();

            /* -------------------------------------------------------------------------- *
             * LOOP P/ CONTROLE PARA NO MAXIMO 10 TENTATIVAS E SE ALGUEM JA VENCEU        *
             * -------------------------------------------------------------------------- */
            while (Tentativas < 10 && Fatality == 0) {
                menu();
                round(tela, TS, OP, TENTATIVASDIGITADAS, passwd, &Tentativas, &RESPOSTA1, &RESPOSTA2, &RESPOSTA3, &contador);
                continuaOuN(TENTATIVASDIGITADAS, passwd, &Fatality, TS, &Tentativas); //DA FIM OU CONTINUA
                reset(&RESPOSTA1, &RESPOSTA2, &RESPOSTA3, &contador, TENTATIVASDIGITADAS, TS); //RESETA CONTEUDO DE X VARIAVEIS
                imprimir(TL, TC, tela); //IMPRIME TELA DO ROUND
                Console.WriteLine("{0} / 10 - Tecle algo p/ continuar.", ++Tentativas);
                Console.ReadKey();
                Console.Clear();
            }
            finish(Fatality, Tentativas, nome);

            Console.ReadKey();
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * FIM DE JOGO                                                                *
         * -------------------------------------------------------------------------- */
        static void finish(int Fatality, int Tentativas, string nome) {
            Console.WriteLine("\n\n\n");
            if (Fatality == 1)
                Console.WriteLine("\t\t\tPARABENS, {0} WINS!\n", nome.ToUpper());
            else
                Console.WriteLine("\t\t\tCOMPUTADOR WINS\n");
            Console.WriteLine("\t\t\tTENTATIVAS: {0} / 10", Tentativas);
            Console.WriteLine("\n\t\t\t\t\tFIM DE JOGO");
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * VERIFICA SE DEVE DAR FIM NO JOGO OU CONTINUAR                              *
         * -------------------------------------------------------------------------- */
        unsafe static void continuaOuN(string[] TENTATIVASDIGITADAS, string[] passwd, int* Fatality, int TS, int* Tentativas) {
            int x = 0;
            for (int i = 0; i < TS; i++)
                if (TENTATIVASDIGITADAS[i] != passwd[i])
                    x++;
            if (x == 0)
                *Fatality = 1;
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * VERIFICACAO DAS TENTATIVAS E ALOCAÇÃO DE RESPOSTAS DO ROUND                *
         * -------------------------------------------------------------------------- */
        unsafe static void round(string[,] tela, int TS, string[] OP, string[] TENTATIVASDIGITADAS, string[] passwd, int* Tentativas, int* RESPOSTA1, int* RESPOSTA2, int* RESPOSTA3, int* contador) {
            Random ALEATORIO = new Random();
            int pr;
            for (int i = 0; i < TS; i++) {
                TENTATIVASDIGITADAS[i] = JOGADA(OP, i, TENTATIVASDIGITADAS);
                tela[*Tentativas, i] = TENTATIVASDIGITADAS[i];
            }
            for (int i = 4; i < 8; i++) {
                do
                    pr = ALEATORIO.Next(4, 8); //POSIÇÃO DA RESPOSTA
                while (pr == *RESPOSTA1 || pr == *RESPOSTA2 || pr == *RESPOSTA3);
                if (i == 4)
                    *RESPOSTA1 = pr;
                else if (i == 5)
                    *RESPOSTA2 = pr;
                else if (i == 6)
                    *RESPOSTA3 = pr;
                tela[*Tentativas, pr] = check(passwd, TENTATIVASDIGITADAS, *contador);
                *contador = *contador + 1;
            }
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * RESETA VARIAVEIS DE RESPOSTAS DO USUARIO                                   *
         * -------------------------------------------------------------------------- */
        unsafe static void reset(int* RESPOSTA1, int* RESPOSTA2, int* RESPOSTA3, int* contador, string[] TENTATIVASDIGITADAS, int TS) {
            *RESPOSTA1 = 0;
            *RESPOSTA2 = 0;
            *RESPOSTA3 = 0;
            *contador = 0;
            for (int i = 0; i < TS; i++)
                TENTATIVASDIGITADAS[i] = "";
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * VERIFICA SE NUMERO E POSIÇÃO ESTÃO CORRETAS                                 *
         * -------------------------------------------------------------------------- */
        static string check(string[] passwd, string[] TENTATIVASDIGITADAS, int contador) {
            int aux = -1;
            int CORESOK = 0, POSICOESOK = 0;
            string result = "";
            while (4 > ++aux) {
                if (TENTATIVASDIGITADAS[contador] == passwd[aux]) {
                    if (contador == aux)
                        POSICOESOK = 1;
                    CORESOK = 1;
                    aux = 5;
                }
            }
            if (POSICOESOK == 1 && CORESOK == 1) //POSICAO V COR V 
                result = "#";
            if (POSICOESOK == 0 && CORESOK == 1) //POSICAO F COR V 
                result = "%";
            return result;
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * GERA UMA SENHA RANDOMICA E NAO REPETIDA                                    *
         * -------------------------------------------------------------------------- */
        static void gerarSenha(string[] passwd, int TS, string[] OP) {
            int random = 0, aux = 0, REPETIDO = 0;
            string AUX;
            Random ALEATORIO = new Random();
            Console.Write("\n\t\t\t---------------------\n\t\t\t\t");
            for (int i = 0; i < TS; i++) {
                do {
                    REPETIDO = 0;
                    random = ALEATORIO.Next(0, 6);
                    AUX = OP[random];
                    foreach (string elemento in passwd)
                        for (int j = 0; j < TS; j++)
                            if (elemento == AUX) //SE REPETIDO
                                REPETIDO = 1;
                } while (aux == random || REPETIDO == 1);
                Console.Write("{1} ", i, OP[random]); //MOSTRA SENHA AO INICIAR
                aux = random;
                passwd[i] = OP[random];
            }
            Console.WriteLine("\n\t\t\t---------------------");
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * MENU DO JOGO                                                               *
         * -------------------------------------------------------------------------- */
        static void menu() {
            Console.Clear();
            Console.WriteLine("\t\t\t  Senha - The Game!\n\n\t\t\t*********************");
            Console.WriteLine(" -> Cores disponíveis p/ escolher:\n");
            Console.WriteLine("\t1 = Azul\n\t2 = Amarelo\n\t3 = Branco\n\t4 = Rosa\n\t5 = Verde\n\t6 = Vermelho \n");
            Console.WriteLine(" -> Legenda:\n");
            Console.WriteLine("\t# = Uma cor ok na posicao ok\n\t% = Uma cor ok na posicao errada\n\tSem preenchimento = Nenhuma cor ou posição correta \n");
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * IMPRIMIR A TELA DE JOGO //MATRIZ                                           *
         * -------------------------------------------------------------------------- */
        static void imprimir(int TL, int TC, string[,] tela) {
            int contador = 0;
            Console.Write("\tSUA RESPOSTA:\t\t\t\tRESPOSTA DO COMPUTADOR:\n------------------------------------------------------------------------------\n");
            for (int i = 0; i < TL; i++) {
                for (int j = 0; j < TC; j++) {
                    if (j == 4)
                        Console.Write("\t|");
                    if (j == 0)
                        Console.Write(contador++);
                    Console.Write("\t" + tela[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.Write("------------------------------------------------------------------------------\n");
        }

        /* FUNÇÃO ------------------------------------------------------------------- *
         * TELA PARA JOGADOR FAZER TENTATIVA                                          *
         * -------------------------------------------------------------------------- */
        static string JOGADA(string[] passwd, int posicao, string[] TENTATIVASDIGITADAS) {
            string result;
            int aux = 0;
            do {
                aux = 0;
                Console.Write("----------------------------\nDIGITE A COR PARA POSICAO {0}: ", posicao, passwd[posicao]);
                result = Convert.ToString(Console.ReadLine()).ToUpper();
                // VERIFICA SE A COR DIGITADA JA FOI DIGITADA NO MESMO ROUND:
                foreach (string elemento in TENTATIVASDIGITADAS)
                    if (elemento == result)
                        aux = 1;
            } while (aux == 1 || result != "1" && result != "2" && result != "3" && result != "4" && result != "5" && result != "6");
            posicao++;
            if (posicao == 4)
                Console.WriteLine("\n");
            return result;

        }
    }
}
