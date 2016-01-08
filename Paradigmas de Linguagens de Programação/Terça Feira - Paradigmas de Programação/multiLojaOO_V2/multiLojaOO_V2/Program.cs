using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            /* ------------------------- *
             * Escolhe a Loja            * 
             * ------------------------- */
            int lojaSelecionada;
            do {
                Console.WriteLine("Selecione a Loja:\n1 - Loja 10 Reáu\n2 - Loja Tudão");
                lojaSelecionada = Convert.ToInt16(Console.ReadLine());
            } while ((lojaSelecionada != 1) && (lojaSelecionada != 2));

            /* ------------------------- *
             * Instanciar a Loja         * 
             * ------------------------- */
            Loja OBJETO_LOJA = new Loja();

            /* --------------------------------------------------- *
             * Define o atributo referente ao nome do objeto loja  * 
             * --------------------------------------------------- */
            if (lojaSelecionada == 1) {
                OBJETO_LOJA.nome = "Loja 10 Reáu";
            }else {
                OBJETO_LOJA.nome = "Loja Tudão";
            }

            /* ---------------------------- *
             * Instanciar o Produto         * 
             * ---------------------------- */
            Produto OBJETO_PRODUTO = new Produto();

            /* -------------------------------------------------------------------------------------------------------- *
             * Após o objeto instanciado(criado), define os atributos do objeto usando ações(métodos) quando necessário * 
             * -------------------------------------------------------------------------------------------------------- */
            Console.WriteLine("Digite o produto: (ex: PC)");
            OBJETO_PRODUTO.nome = Console.ReadLine();
            Console.WriteLine("Digite o valor: (ex: 100.50)");
            OBJETO_PRODUTO.valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o desconto: (ex: 4.10)");
            OBJETO_PRODUTO.desconto = Convert.ToDouble(Console.ReadLine());
            OBJETO_PRODUTO.valorDescontado = OBJETO_LOJA.calcula_desconto(OBJETO_PRODUTO.valor, OBJETO_PRODUTO.desconto);
            if (lojaSelecionada == 2) {
                OBJETO_PRODUTO.valorParcela = OBJETO_LOJA.define_parcela(OBJETO_PRODUTO.valorDescontado);
            }

            /* -------------------------------------------- *
             * Usa ação(método) de imprimir dados do objeto * 
             * -------------------------------------------- */
            OBJETO_LOJA.imprime(OBJETO_PRODUTO, lojaSelecionada);

            Console.ReadKey();
        }
    }
}
