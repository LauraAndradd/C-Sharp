﻿using System;
using System.Globalization;

namespace CursoUdemy
{
    class Exercicio1
    {
        static void Main(String[] args) 
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.1234555;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $" +preco1);
            Console.WriteLine(produto2 + ", cujo preço é $" +preco2);

            Console.WriteLine("Registro: " +idade + "anos de idade, código " + codigo + "e genero: " +genero);
            Console.WriteLine("Medida" + medida);
            Console.WriteLine("Arredondando 3 casas " + medida.ToString("F3"));
            Console.WriteLine("Separador " +medida.ToString("F2" , CultureInfo.InvariantCulture));
        }

    }
}
