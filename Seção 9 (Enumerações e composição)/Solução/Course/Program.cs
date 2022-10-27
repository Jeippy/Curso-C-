using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            string t2 = OrderStatus.Delivered.ToString();

            OrderStatus s2 = Enum.Parse<OrderStatus>("Shipped");

            OrderStatus os = Enum.Parse<OrderStatus>("Delivere");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}