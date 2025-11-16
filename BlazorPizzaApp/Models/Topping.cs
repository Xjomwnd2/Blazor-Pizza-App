namespace BlazorPizzaApp.Models
{
    public class Topping
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public string GetFormattedPrice() => Price.ToString("0.00");
    }

    public class PizzaTopping
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public int ToppingId { get; set; }
        public Topping? Topping { get; set; }
    }
}
