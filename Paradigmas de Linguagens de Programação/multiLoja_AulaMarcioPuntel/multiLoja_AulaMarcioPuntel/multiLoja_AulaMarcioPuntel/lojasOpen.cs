using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /* ------------------------- *
         * Função de selecionar a Loja a Entrar * 
         * ------------------------- */
        static int selecionarLoja() {
            int var;
            do {
                Console.WriteLine("Selecione a Loja:\n1 - Loja 10 Reáu\n2 - Loja Tudão");
                var = Convert.ToInt16(Console.ReadLine());
            } while ((var != 1) && (var != 2));
            return var;
        }

        /* ------------------------- *
         * Função principal * 
         * ------------------------- */
        static void Main(string[] args) {
            /* ------------------------- *
             * Carrega função para escolher a Loja * 
             * ------------------------- */
            int lojaSelecionada;
            lojaSelecionada = selecionarLoja();
            /* ------------------------- *
             * Instanciar a Loja 10 Reau * 
             * ------------------------- */
            if (lojaSelecionada == 1) {
                Loja InstanciaLoja = new Loja();
                InstanciaLoja.nome = "Loja 10 Reáu";
                Produto InstanciaProduto = new Produto();
                InstanciaProduto.nome = "Caneca";
                InstanciaProduto.valor = 5.00;
                InstanciaProduto.desconto = 1.00;
                InstanciaProduto.valorDescontado = InstanciaLoja.calcula_desconto(InstanciaProduto.valor, InstanciaProduto.desconto);
                InstanciaLoja.imprime(InstanciaProduto,1);
                /* ------------------------- *
                 * Instanciar a Loja Tudão * 
                 * ------------------------- */
            } else if (lojaSelecionada == 2) {
                Loja InstanciaLoja = new Loja();
                InstanciaLoja.nome = "Loja Tudão";
                Produto InstanciaProduto = new Produto();
                InstanciaProduto.nome = "Caneca";
                InstanciaProduto.valor = 5.00;
                InstanciaProduto.desconto = 1.00;
                InstanciaProduto.valorDescontado = InstanciaLoja.calcula_desconto(InstanciaProduto.valor, InstanciaProduto.desconto);
                InstanciaProduto.valorParcela = InstanciaLoja.define_parcela(InstanciaProduto.valorDescontado);
                InstanciaLoja.imprime(InstanciaProduto,2);
            }
            /* ------------------------- *
             * Fim do Programa * 
             * ------------------------- */
            Console.ReadKey();
        }
    }
}
