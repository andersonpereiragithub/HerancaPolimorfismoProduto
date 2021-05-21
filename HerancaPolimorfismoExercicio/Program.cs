using HerancaPolimorfismoExercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();

            Console.Write("Informe a quantidade de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informação Produto #{i}: ");
                Console.Write("Normal, usadado ou importado (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch.Equals('i'))
                {
                    Console.Write("Taxa Alfandegária: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product produtoImportado = new ImportedProduct(name, preco, taxa);
                    lista.Add(produtoImportado);
                }
                else if (ch.Equals('u'))
                {
                    Console.Write("Data de Fabricação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Product produtoUsado = new UsedProduct(name, preco, data);
                    lista.Add(produtoUsado);
                }
                else
                {
                    Product produto = new Product(name, preco);
                    lista.Add(produto);
                }
            }
            Console.WriteLine("\nEtiquetas de Preços: ");
            foreach (Product item in lista)
            {
                    Console.WriteLine(item.PriceTag());
            }
            Console.ReadKey();
        }
    }
}
