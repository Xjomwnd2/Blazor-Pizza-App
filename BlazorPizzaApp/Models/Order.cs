namespace BlazorPizzaApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; }
        public Address DeliveryAddress { get; set; } = new Address();
        public List<OrderPizza> Pizzas { get; set; } = new List<OrderPizza>();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }

    public class OrderPizza
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PizzaSpecialId { get; set; }
        public PizzaSpecial? Special { get; set; }
        public int Size { get; set; }
        public List<PizzaTopping> Toppings { get; set; } = new List<PizzaTopping>();

        public decimal GetBasePrice()
        {
            return ((decimal)Size / 12m) * (Special?.BasePrice ?? 0);
        }

        public decimal GetTotalPrice()
        {
            return GetBasePrice() + Toppings.Sum(t => t.Topping?.Price ?? 0);
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}
