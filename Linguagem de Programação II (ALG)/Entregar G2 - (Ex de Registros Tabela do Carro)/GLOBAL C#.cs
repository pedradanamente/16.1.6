using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void imprime() {
            Console.WriteLine("Valor da global: {0}", global);
        }

        ///* ---------------------------------- *
        //FUNCIONA
        public static string global {
            set;
            get;
        }
        static void Main(string[] args) {
            global = "CONTEUDO";
            imprime();
            Console.ReadKey();
        }
        //---------------------------------- */

        /* ---------------------------------- *
        //NAO FUNCIONA
        static void Main(string[] args) {
            public string global = "CONTEUDO";
            imprime();
            Console.ReadKey();
        }
        /* ---------------------------------- */
    }
}
