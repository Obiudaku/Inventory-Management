using System;

public class OrderLogger
{
    public void HandleOrderStatusChanged(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"Order {e.OrderId} status changed to {e.NewStatus}");
    }
}
