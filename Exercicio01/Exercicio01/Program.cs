namespace Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois valores inteiros: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1+ num2;

            Console.WriteLine(num1 + "+" + num2 + "=" + soma);
        }
    }
}
