using System;

namespace Exercicio06
{
    class Exercicio06
    {
        static void Main(string[] args)
        {
            Info a = new Info();
            Info b = new Info();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.idade = int.Parse(Console.ReadLine());

            if(a.idade > b.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.nome);
            }


        }
    }
}
