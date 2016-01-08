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
            Console.WriteLine("Qual a quantidade de parcelas? ");
            parcelas = Convert.ToInt16(Console.ReadLine());
            return vd / parcelas;
        }
        public void imprime(Produto var1, int var2) {
            Console.WriteLine(nome);
            Console.WriteLine("Produto: {0}", var1.nome);
            Console.WriteLine("Preço: {0:C}", var1.valor);
            Console.WriteLine("Desconto: {0:C}", var1.desconto);
            if (var2 == 2) {
                Console.WriteLine("Valor da parcela: {0:C}", var1.valorParcela);
            }
            Console.WriteLine("Preço Final: {0:C}", var1.valorDescontado);
        }
    }
}
