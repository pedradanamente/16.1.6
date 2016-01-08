        static void Main(string[] args) {
            const int TL = 6;
            const int TC = 7;
            int[,] myArray = new int[TL,TC];
            int i, j, soma = 0;
            for (i=0;i<TL;i++){
                for (j=0;j<TC;j++){
                    Console.WriteLine("Digite um valor p/ a Linha {0} e Coluna {1}:", i, j);
                    myArray[i,j]=Convert.ToInt16(Console.ReadLine());
                    soma+=myArray[i,j];
                }
            }
            Console.WriteLine("A soma dos valores da matriz é: {0}", soma);
            Console.ReadKey();
        }