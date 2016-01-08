        static void Main(string[] args) {
            const int L = 6;
            const int C = 5;
            int[,] myArray = new int[L, C];
            int i, j;
            for (i = 0; i < L; i++) {
                for (j = 0; j < C; j++) {
                    Console.WriteLine("Digite um valor p/ o indice L: {0} C: {1}",i ,j);
                    myArray[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            for (i = 0; i < L;i++) {
                for (j = 0; j < C;j++) {
                    Console.Write("{0} \t",myArray[i,j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }