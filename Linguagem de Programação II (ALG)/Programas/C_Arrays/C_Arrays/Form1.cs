using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_Arrays
{
    public partial class Form1 : Form
    {
        int[] numeros = { 10, 9, 8, 7, 6, 5 };
        int[,] numeros2 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            int[,] matriz3x3 = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            listBox1.Items.Add("Primeiro elemento: numeros[0] = " + numeros[0]);
            listBox1.Items.Add("Segundo elemento: numeros[1] = " + numeros[1]);
            listBox1.Items.Add("Terceiro elemento: numeros[2] = " + numeros[2]);
            listBox1.Items.Add("Quarto elemento: numeros[3] = " + numeros[3]);
            listBox1.Items.Add("Quarto elemento: numeros[4] = " + numeros[4]);

            listBox2.Items.Add("numeros2[0,0] = " + numeros2[0, 0]);
            listBox2.Items.Add("numeros2[0,1] = " + numeros2[0, 1]);
            listBox2.Items.Add("numeros2[1,0] = " + numeros2[1, 0]);
            listBox2.Items.Add("numeros2[1,1] = " + numeros2[1, 1]);
            listBox2.Items.Add("numeros2[2,0] = " + numeros2[2, 0]);
            listBox2.Items.Add("numeros2[2,1] = " + numeros2[2, 1]);
            listBox2.Items.Add("numeros2[3,0] = " + numeros2[3, 0]);
            listBox2.Items.Add("numeros2[3,1] = " + numeros2[3, 1]);
            listBox2.Items.Add("numeros2[4,0] = " + numeros2[4, 0]);
            listBox2.Items.Add("numeros2[4,1] = " + numeros2[4, 1]);

              
        }

        private void btnLacoFor_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 6 ; i++)
            {
                listBox1.Items.Add("Elemento [" + i +"] = " + numeros[i]);
            }
        }

        private void btnLacoFor2_Click(object sender, EventArgs e)
        {
            int[] inteiros = new int[10];

            listBox1.Items.Clear();
            listBox1.Items.Add("Array inteiros => int[] inteiros = new int[10]");

            for (int i = 0; i < 10; i++)
            {
                inteiros[i] = i;
                listBox1.Items.Add("Elemento [" + i + "] = " + i );
                
            }

        }

        private void btnforeach_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add("Usando laço foreach");
 
            int[] numeros = new int[5];

            numeros[0] = 10;
            numeros[1] = 4;
            numeros[2] = 32;
            numeros[3] = 1;
            numeros[4] = 20;

            foreach (int i in numeros)
            {
                listBox1.Items.Add("i = " + i);
            }
        }

        private void btnforeach2_Click(object sender, EventArgs e)
        {
            //int[,] numeros = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            listBox2.Items.Clear();
            listBox2.Items.Add("Usando laço foreach com vetor bidimensional");
            foreach (int i in numeros2)
            {
                listBox2.Items.Add("i= " + i);
            }
        }

        private void btnforeachstrings_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-feira";
            semana[2] = "Terça-feira";
            semana[3] = "Quarta-feira";
            semana[4] = "Quinta-feira";
            semana[5] = "Sexta-feira";
            semana[6] = "Sábado";

            foreach (string dia in semana)
            {
               listBox1.Items.Add(dia);
            }

        }

        private void btnMetodosPropriedades_Click(object sender, EventArgs e)
        {
            string[] Cores = { "vermelho", "verde", "amarelo", "laranja", "azul" };
            //outra forma de iniciar o array
            //string[] Cores = new string[] { "vermelho", "verde", "amarelo", "laranja", "azul" };
            listBox2.Items.Clear();
            listBox2.Items.Add("Tamanho do array => (Cores.Length) = " + Cores.Length);
            if (Cores.IsFixedSize)
            {
                listBox2.Items.Add("O array é variável => (Cores.IsFixedSize) = ");
                listBox2.Items.Add(" tamanho   => (Cores.Lenght) = " + Cores.Length);
                listBox2.Items.Add(" intervalo => (Cores.Rank)   = " + Cores.Rank);
            }

                listBox2.Items.Add("Procurando itens no array : procurando 'verde'");
                object oCor = "verde";
                int retorno = Array.BinarySearch(Cores, oCor);
                if(retorno >=0)
                    listBox2.Items.Add("Indice do Item " + retorno.ToString());
                else
                    listBox2.Items.Add("Item não localizado");

                listBox2.Items.Add("Ordenando Array = Array Original:");
                foreach (string str in Cores)
                {
                 listBox2.Items.Add(str);
                }
               
                listBox2.Items.Add("Array Ordenado:");
                //Array.Sort(Cores);
                Array.Reverse(Cores);
                foreach (string str in Cores)
                {
                 listBox2.Items.Add(str);
                }

                Cores.Reverse();

                listBox2.Items.Add("Usando GetLowerBound e GetUpperBound"); 
                for( int j = Cores.GetLowerBound(0); j <= Cores.GetUpperBound(0); j++)
                   listBox2.Items.Add("Cores[0] = " +  j + " " + Cores[j]);


                int ind = Array.IndexOf(Cores, "verde");
                listBox2.Items.Add("O índice do item 'verde' e " + ind);
        }

    
    }
}
