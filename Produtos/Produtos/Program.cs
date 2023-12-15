using Produtos.Entities;
using System.Globalization;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Qtde de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto #{i + 1} dados: ");
                Console.Write("Comum,  Usado, Importado (c / u / i)? ");
                char ch = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (ch == 'U')
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    string manufactureDate = Console.ReadLine();

                    list.Add(new UsedProduct(name, price, manufactureDate));
                } else if (ch == 'I')
                {
                    Console.Write("Valor da Taxa: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}