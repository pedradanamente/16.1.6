/*Escrevendo em um arquivo texto*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace testeArquivo
{
    class Program
    {
        static void Main(string[] args)
        {   
            StreamWriter wr = new StreamWriter("c:\\teste.txt");                
            wr.Write("Testando a criação de um arquivo texto!");
            wr.Write("Continuo escrevendo na mesma linha :-)");

            wr.Close();

            Console.WriteLine("Abra o arquivo e verifique se gravei corretamente seus dados!");
            
            Console.ReadKey();
        }
    }
}

