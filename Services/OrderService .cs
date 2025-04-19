using ClothingStore.Models;
public class OrderService
{
    private List<Order> _orders = new List<Order>();

    public List<Order> GetOrders() => _orders;

    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }
}