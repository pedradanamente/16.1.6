using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Loja
    {
        public string nome;
        public double calcula_desconto(double vp, double vd) {
            return vp - vd;
        }
        public double define_parcela(double vd) {
            int parcelas;
            Console.WriteLine("QUAL O NUMERO DE PARCELAS TU CONSEGUE PAGAR MAGRAO? ");
            parcelas = Convert.ToInt16(Console.ReadLine());
            return vd / parcelas;
        }
        public void imprime(Produto var1, int var2) {
            Console.WriteLine(nome);
            Console.WriteLine("PRODUTO:" + var1.nome);
            Console.WriteLine("PRECO:" + var1.valor);
            Console.WriteLine("DESCONTO:" + var1.desconto);
            if (var2 == 2) {
                Console.WriteLine("VALOR DA PARCELA:" + var1.valorParcela);
            }
            Console.WriteLine("PRECO FINAL:" + var1.valorDescontado);
        }
    }
}
