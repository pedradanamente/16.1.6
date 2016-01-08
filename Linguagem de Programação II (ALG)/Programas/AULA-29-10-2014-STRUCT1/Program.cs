using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /* ----------------------------------------------------- *
         * TABELA CARRO
         * ----------------------------------------------------- */
        struct Carro
        {
            public string marca;
            public double preco;
            public int ano;
            public string cor;
        }
        /* ----------------------------------------------------- *
         * PRINCIPAL
         * ----------------------------------------------------- */
        static void Main(string[] args) {
            const int T = 5;
            int PARAMETRO, cont = 0;
            bool cheio;
            Carro[] cadastroCarro = new Carro[T];
            PARAMETRO = menu();
            while (PARAMETRO != 5) {
                PARAMETRO = invalido(PARAMETRO);//verifica opcao
                switch (PARAMETRO) {
                    case 1://Incluir
                        cheio = verificaCheio(cont, T);
                        if (cheio == false) {
                            cadastro(cadastroCarro, cont);
                            PARAMETRO = menu();
                            cont++;
                        }
                        PARAMETRO = menu();
                        break;
                    case 2://Pesquisar Preço
                        pesquisaPreco(cadastroCarro, cont);
                        PARAMETRO = menu();
                        break;
                    case 3://Pesquisa Marca

                        PARAMETRO = menu();
                        break;
                    case 4://Ordenar
                        PARAMETRO = menu();
                        break;
                }

            }

        }
        /* ----------------------------------------------------- *
         * MENU
         * ----------------------------------------------------- */
        static int menu() {
            int PARAMETRO;
            Console.WriteLine("\n Cadastrar Carro.(1)");
            Console.WriteLine("\n Pesquisar carro por Preço.(2)");
            Console.WriteLine("\n Pesquisar carro por Marca.(3)");
            Console.WriteLine("\n Pesquisar carro por ano, marca e cor.(4)");
            Console.WriteLine("\n Sair(5)");
            PARAMETRO = Convert.ToInt16(Console.ReadLine());
            return PARAMETRO;

        }
         /* ----------------------------------------------------- *
          * VALIDACAO PARA O PARAMETRO DE OPCAO ESCOLHIDO
          * ----------------------------------------------------- */
        static int invalido(int PARAMETRO) {
            while (PARAMETRO < 1 || PARAMETRO > 5) {
                Console.WriteLine("PARAMETRO INVALIDO");
                PARAMETRO = menu();
            }
            return PARAMETRO;//retorna a opcao para o Main.
        }
        /* ----------------------------------------------------- *
         * ATINGE LIMITE DE UNIDADES
         * ----------------------------------------------------- */
        static bool verificaCheio(int cont, int T) {
            bool cheio = false;
            if (cont == T - 1) {
                Console.WriteLine("LIMITE DE UNIDADES ATINGIDO");
                cheio = true;
            }
            return cheio;
        }
        /* ----------------------------------------------------- *
         * CADASTRO DE CARACTERISTICAS DO CARRO
         * ----------------------------------------------------- */
        static void cadastro(Carro[] c, int x) {
            Console.WriteLine("DEFINA A MARCA:");
            c[x].marca = Console.ReadLine();
            Console.WriteLine("DEFINA O PREÇO:");
            c[x].preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DEFINA O ANO:");
            c[x].ano = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("DEFINA A COR:");
            c[x].cor = Console.ReadLine();
        }
        /* ----------------------------------------------------- *
         * EXIBIÇÃO DAS CARACTERISTICAS DO CARRO EM TELA
         * ----------------------------------------------------- */
        static void mostraDados(Carro[] c, int x) {
            Console.WriteLine("MARCA: {0}", c[x].marca);
            Console.WriteLine("ANO: {0}", c[x].ano);
            Console.WriteLine("PREÇO: {0}", c[x].preco);
            Console.WriteLine("COR:{0}", c[x].cor);
        }
        /* ----------------------------------------------------- *
         * PESQUISA POR PRECO
         * ----------------------------------------------------- */
        static void pesquisaPreco(Carro[] c, int cont) {
            int x;
            double preco;
            Console.WriteLine("DIGITE O VALOR DE PESQUISA PARA PREÇO:");
            preco = Convert.ToDouble(Console.ReadLine());
            for (x = 0; x < cont; x++) {
                if (c[x].preco <= preco) {
                    mostraDados(c, x);
                }

            }
        }
        /* ----------------------------------------------------- *
         * PESQUISA POR MARCA
         * ----------------------------------------------------- */
        static void pesquisaMarca(Carro[] c, int cont) {
            int x;
            string marca;
            Console.WriteLine("DIGITE O VALOR DE PESQUISA PARA MARCA:");
            marca = Console.ReadLine();
            for (x = 0; x < cont; x++) {
                if (c[x].marca == marca) {
                    mostraDados(c, x);
                }

            }
        }

    }
}
