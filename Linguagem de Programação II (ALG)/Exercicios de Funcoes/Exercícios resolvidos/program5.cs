static void Main(string[] args)
{
	double b, e, r;
	Console.Write("Digite o valor da base: ");
	b = Convert.ToDouble(Console.ReadLine());
	Console.Write("Digite o valor do expoente: ");
	e = Convert.ToDouble(Console.ReadLine());
	r = calcp(b, e);
	Console.WriteLine("A o resultado da potência do primeiro numero elevado ao segundo número é: {0}", r);
	Console.ReadKey();
}
static double calcp(double b, double e)
{
	double r;
	r = Math.Pow(b, e); 
	return r;
}