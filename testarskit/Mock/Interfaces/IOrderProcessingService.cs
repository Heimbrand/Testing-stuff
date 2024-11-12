using testarskit.Mock.Entities;

namespace testarskit.Mock.Interfaces;

public interface IOrderProcessingService
{
    Order PlaceOrder(OrderDetails orderDetails);
    bool CancelOrder(int orderId);
    Order GetOrderDetails(int orderId);
}