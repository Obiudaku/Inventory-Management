using System;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            OrderLogger logger = new OrderLogger();

            order.OrderStatusChanged += logger.HandleOrderStatusChanged;

            // Test the event
            order.OrderId = "12345";
            order.Status = "Shipped";

            Console.ReadLine();
        }
    }
}
