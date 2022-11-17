namespace Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area, pi = 3.14159; 

            area = pi * Math.Pow(raio, 2.0);

            Console.WriteLine("A area é " + area);

        }

    }

}
