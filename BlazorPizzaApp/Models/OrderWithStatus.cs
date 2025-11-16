namespace BlazorPizzaApp.Models
{
    public class OrderWithStatus
    {
        public Order Order { get; set; } = new Order();
        public string StatusText { get; set; } = string.Empty;
        public bool IsDelivered => StatusText == "Delivered";

        public static OrderWithStatus FromOrder(Order order)
        {
            string statusText;
            var dispatchTime = order.CreatedTime.Add(TimeSpan.FromSeconds(10));
            var deliveryDuration = TimeSpan.FromMinutes(1);

            if (DateTime.Now < dispatchTime)
            {
                statusText = "Preparing";
            }
            else if (DateTime.Now < dispatchTime + deliveryDuration)
            {
                statusText = "Out for delivery";
            }
            else
            {
                statusText = "Delivered";
            }

            return new OrderWithStatus
            {
                Order = order,
                StatusText = statusText
            };
        }
    }
}
