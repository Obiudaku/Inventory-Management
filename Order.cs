using System;

public delegate void OrderStatusChangedEventHandler(object sender, OrderEventArgs e);

public class Order
{
    public event OrderStatusChangedEventHandler OrderStatusChanged;

    private string _orderId;
    private string _status;

    public string OrderId
    {
        get => _orderId;
        set
        {
            if (_orderId != value)
            {
                _orderId = value;
                OnOrderStatusChanged(new OrderEventArgs(_orderId, _status));
            }
        }
    }

    public string Status
    {
        get => _status;
        set
        {
            if (_status != value)
            {
                _status = value;
                OnOrderStatusChanged(new OrderEventArgs(_orderId, _status));
            }
        }
    }

    protected virtual void OnOrderStatusChanged(OrderEventArgs e)
    {
        OrderStatusChanged?.Invoke(this, e);
    }
}
