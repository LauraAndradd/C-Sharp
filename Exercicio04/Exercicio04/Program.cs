namespace Exercicio04
{
    class Exercicio04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor das horas: ");
            double valor = double.Parse(Console.ReadLine());

            double salario = horas * valor;

            Console.WriteLine("Number: " + numero);
            Console.WriteLine("Salário: " + salario);
        }
    }
}
