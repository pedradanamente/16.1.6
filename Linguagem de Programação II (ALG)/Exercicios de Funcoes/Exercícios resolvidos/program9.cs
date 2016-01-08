class Program
{
	static void Main(string[] args) {
		int a, b, c, r;
		do {
			Console.WriteLine("Digite um valor para A:");
			a = Convert.ToInt16(Console.ReadLine());
		} while (a <= 1);
		Console.WriteLine("Digite um valor para B:");
		b = Convert.ToInt16(Console.ReadLine());
		do {
			Console.WriteLine("Digite um valor para C:");
			c = Convert.ToInt16(Console.ReadLine());
		} while (c <= b);
		r = soma(b, c, a);
		Console.WriteLine("Resultado da soma: {0}", r);
		Console.ReadKey();
	}

	static int soma(int b, int c, int a) {
		int i, r = 0;
		for (i = b + 1; i < c; i++) {
			Console.WriteLine("Intervalo: {0}", i);
			if (i % a == 0) {
				r += i;
			}
		}
		return r;
	}
}
