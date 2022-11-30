namespace Aula71
{
    class Aula71
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string name, email;
                int quarto;

                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto= int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(name, email); 

            }

            Console.WriteLine("Quartos ocupados:");

            for(int i = 0; i < 10; i++) {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i].Nome + ", " + vect[i].Email);
                }
            }

        }
    }
}
