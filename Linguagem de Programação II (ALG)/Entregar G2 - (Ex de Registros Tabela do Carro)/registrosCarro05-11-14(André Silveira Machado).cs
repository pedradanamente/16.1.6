using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //André Silveira Machado

        /* ****************************** *
         * Tabela "Carro"                 *
         * ****************************** */
        struct Carro
        {
            public string marca;
            public double preco;
            public int ano;
            public string cor;
        }

        /* ****************************** *
         * Função Principal               *
         * ****************************** */
        static void Main(string[] args) {
            const int T = 5;
            q = 0;
            Carro[] tCarro = new Carro[T];
            load(tCarro, T);
        }
        /* ****************************** *
         * Menu // Entrada de dados       *
         * ****************************** */
        static int menu(int T) {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Quantidade: {0} / {1}", q, T);
            Console.WriteLine("-------------------------");
            Console.WriteLine("......  Welcome  ......\n");
            Console.WriteLine("[ 1 ] - Incluir");
            Console.WriteLine("[ 2 ] - Pesquisar por preço máximo");
            Console.WriteLine("[ 3 ] - Pesquisar por marca");
            Console.WriteLine("[ 4 ] - Pesquisar por marca, ano e cor");
            Console.WriteLine("[ 5 ] - Sair");
            Console.WriteLine("-------------------------");
            Console.Write("Opção: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        /* ****************************** *
         * Menu // Processamento          *
         * ****************************** */
        static void load(Carro[] tCarro, int T) {
            int op;
            do {
                op = menu(T);
            } while ((op != 1) && (op != 2) && (op != 3) && (op != 4) && (op != 5));

            //incluir
            if (op == 1) {
                if (full(T) == 0) {
                    incluir(tCarro);
                } else {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Limite atingido!");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Tecle algo p/ continuar.");
                    Console.ReadKey();
                }
            }
                //pesquisar preço
            else if (op == 2) {
                pesquisar_preco(tCarro);
            }
                //pesquisar marca
            else if (op == 3) {
                pesquisar_marca(tCarro);
            }
                //pesquisar marca, preço, ano, cor
            else if (op == 4) {
                pesquisar_todos(tCarro);
            }
            //retornar ao menu
            if (op != 5) {
                load(tCarro, T);
            }
        }

        /* ****************************** *
         * Limite                         *
         * ****************************** */
        static int full(int T) {
            if (q == T) {
                return 1;
            } else {
                return 0;
            }
        }

        /* ****************************** *
         * Incluir                        *
         * ****************************** */
        static void incluir(Carro[] tCarro) {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Inclusão");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Marca do Carro:");
            tCarro[q].marca = Console.ReadLine();
            tCarro[q].marca = tCarro[q].marca.ToUpper();
            Console.WriteLine("Preço do Carro:");
            tCarro[q].preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ano do Carro:");
            tCarro[q].ano = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Cor do Carro:");
            tCarro[q].cor = Console.ReadLine();
            tCarro[q].cor = tCarro[q].cor.ToUpper();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Incluído!");
            Console.WriteLine("-------------------------");
            q++;

            Console.ReadKey();

        }

        /* ****************************** *
         * Imprime                        *
         * ****************************** */
        static void imprime(Carro[] tCarro, int i) {
            Console.WriteLine("ID: {0} - Marca: {1}, Ano: {2}, Cor: {3}, Preço: {4:C}", i, tCarro[i].marca, tCarro[i].ano, tCarro[i].cor, tCarro[i].preco);
        }

        /* ****************************** *
         * Pesquisa Geral                 *
         * ****************************** */
        static void pesquisar(Carro[] tCarro, int op) {
            int localizados = 0;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("  INICIO DA PESQUISA");
            Console.WriteLine("--------------------------------------------------------");
            for (int i = 0; i < q; i++) {
                if (op == 2) {
                    if (tCarro[i].preco <= preco) {
                        imprime(tCarro, i);
                        localizados++;
                    }
                }
                if (op == 3) {
                    if (tCarro[i].marca == marca) {
                        imprime(tCarro, i);
                        localizados++;
                    }
                }
                if (op == 4) {
                    if ((tCarro[i].marca == marca) && (tCarro[i].ano == ano) && (tCarro[i].cor == cor)) {
                        imprime(tCarro, i);
                        localizados++;
                    }
                }
            }
            if (localizados == 0) {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("A pesquisa não retornou nenhum resultado!");
                Console.WriteLine("--------------------------------------------------------");
            }
            Console.ReadKey();
            Console.Clear();
        }
        /* *********************************** *
         * #2 - Pesquisa por preco máximo      *
        /* *********************************** */
        static void pesquisar_preco(Carro[] tCarro) {
            Console.Clear();
            Console.WriteLine("Digite o Valor desejado");
            preco = Convert.ToDouble(Console.ReadLine());
            pesquisar(tCarro, 2);
        }

        /* *********************************** *
         * #3 - Pesquisa por marca             *
        /* *********************************** */
        static void pesquisar_marca(Carro[] tCarro) {
            Console.Clear();
            Console.WriteLine("Digite a marca desejada");
            marca = Console.ReadLine();
            marca = marca.ToUpper();
            pesquisar(tCarro, 3);
        }

        /* *********************************** *
         * #4 - Pesquisa por todos os campos   *
         * *********************************** */
        static void pesquisar_todos(Carro[] tCarro) {
            Console.WriteLine("Digite a marca desejada");
            marca = Console.ReadLine();
            marca = marca.ToUpper();
            Console.WriteLine("Digite o ano desejado");
            ano = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a cor desejada");
            cor = Console.ReadLine();
            cor = cor.ToUpper();
            pesquisar(tCarro, 4);
        }

        /* ************************************************************ *
         * Gambiarra p/ Variavel Global                                 *
         * Ja que isso não é PHP noix se vira como póde p/ facilitar!   *
         * Não da p/ fujir do C# mas dá pra fazer Gambiarra nele Também *
         * ************************************************************ */
        public static int q { set;get; }
        public static double preco { set;get; }
        public static string marca { set;get; }
        public static int ano { set;get; }
        public static string cor { set;get; }

    }
}