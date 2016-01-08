static void Main(string[] args)
{
	int value;
	Console.Write("Digite um valor:");
	value = Convert.ToInt16(Console.ReadLine());
	soma(value);
	Console.ReadKey();
}
static void soma(int value)
{
	int i, soma = 0;
	for (i = 1; i <= value; i++) {
		soma += i;
	}
	Console.WriteLine("O somatório dos valores de 1 até {0} é {1}", value, soma);
}