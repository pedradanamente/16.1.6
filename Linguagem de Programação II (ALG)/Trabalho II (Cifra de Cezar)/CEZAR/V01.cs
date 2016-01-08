using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMPERIOROMANO
{
    class Program
    {
        static void Main(string[] args) {
            int a, slotdaletra;
            string x, mensagem, desloca; //ALTERADO
            string abcdario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //ALTERADO
            do {
                desloca = "";
                Console.WriteLine("Digite o total de deslocamentos:");
                slotdaletra = Convert.ToInt16(Console.ReadLine());
                Console.Write("Escreva a mensagem: \n");
                mensagem = Console.ReadLine();
                for (int indice = 0; indice < mensagem.Length; indice++) {
                    x = mensagem[indice].ToString();
                    int ultimaletra = 0;
                    for (a = 0; a < abcdario.Length; a++) {
                        string TESTA=abcdario[a].ToString(); //ALTERADO
                        if (TESTA == x) { //ALTERADO
                            ultimaletra = a + slotdaletra;
                            if (ultimaletra <= 26) {
                                desloca = desloca + abcdario[ultimaletra];
                            } else {
                                ultimaletra = ultimaletra - 26;
                                desloca = desloca + abcdario[ultimaletra];
                            }
                        }
                    }
                }
                Console.WriteLine("MENSAGEM CIFRADA: ", desloca);
            }
            while (slotdaletra >= 0);
            Console.ReadKey();
        }
    }
}