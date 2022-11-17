using System.Globalization;

namespace Exercicio03
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 4 valores inteiros: ");
            string[] vet = Console.ReadLine().Split(' ');
            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int num3 = int.Parse(vet[2]);
            int num4 = int.Parse(vet[3]);

            double diferença = (num1 * num2) - (num3 * num4);   

            Console.WriteLine(diferença.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
