using System;

namespace Enumeracao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            System.Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            System.Console.WriteLine(os);
            System.Console.WriteLine(txt);
        }
    }
}

https://github.com/acenelio/composition1-csharp