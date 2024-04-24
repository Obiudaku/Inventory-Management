using System;

public class OrderEventArgs : EventArgs
{
    public string OrderId { get; set; }
    public string NewStatus { get; set; }

    public OrderEventArgs(string orderId, string newStatus)
    {
        OrderId = orderId;
        NewStatus = newStatus;
    }
}
