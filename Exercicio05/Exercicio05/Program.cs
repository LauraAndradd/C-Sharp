namespace Exercicio05
{
    class Exercicio05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero >= 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }


}

