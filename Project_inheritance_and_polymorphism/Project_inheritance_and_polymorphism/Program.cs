using Project_inheritance_and_polymorphism.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_inheritance_and_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProduct = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + " data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = Char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    listProduct.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (type == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listProduct.Add(new ImportedProduct(name, price, customFee));
                }
                else if(type == 'c')
                {
                    listProduct.Add(new Product(name, price));
                }
                else
                {
                    Console.WriteLine("\nOpção inválida\n");
                }
            }

            Console.WriteLine("\nPrice tags:");
            foreach (Product product in listProduct)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
