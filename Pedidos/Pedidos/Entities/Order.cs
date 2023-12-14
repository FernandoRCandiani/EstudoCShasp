
using Pedidos.Entities.Enum;
using System.Globalization;
using System.Text;

namespace Pedidos.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();

        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client client) 
        { 
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem order) { OrderItens.Add(order);  }
        public void AddRemove(OrderItem order) { OrderItens.Remove(order); }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem order in OrderItens)
            {
                sum += order.SubTotal(order.Quantity, order.Price);
            }
            return sum; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento Pedido: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Momento Status: " + Status);
            sb.AppendLine("Cliente: " + Client);
            foreach (OrderItem order in OrderItens) { sb.AppendLine(order.ToString()); }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
