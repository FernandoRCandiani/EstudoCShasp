using Pedidos.Entities;
using Pedidos.Entities.Enum;
using System.Globalization;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrar com dados do Cliente:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data de aniversario (DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, dateBirth);

            Console.WriteLine("Entrar dados do pedido:");
            Console.Write("Status (Pending_Payment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos produtos no pedido? ");
            int qtdePedido = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdePedido; i++)
            {
                Console.WriteLine($"Entrar #{i + 1} dados do item:");
                Console.Write("Nome produto: ");
                string nomeProduto = Console.ReadLine();
                
                Console.Write("Valor do produto: ");
                double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade: ");
                int qtdeProduto = int.Parse(Console.ReadLine());

                Product product = new Product(nomeProduto, valorProduto);
                OrderItem orderItem = new OrderItem(qtdeProduto, valorProduto, product);
                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order); ;
        }
    }
}
