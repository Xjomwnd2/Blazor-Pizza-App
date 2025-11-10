namespace BlazorPizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
    }

    public class PizzaService
    {
        public static List<Pizza> GetPizzas()
        {
            return new List<Pizza>
            {
                new Pizza
                {
                    Id = 1,
                    Name = "Margherita",
                    Description = "Classic pizza with tomato sauce, mozzarella, and basil",
                    BasePrice = 1299m, // ~10 USD in KES
                    ImageUrl = "img/pizzas/margherita.jpg",
                    Vegetarian = true,
                    Vegan = false
                },
                new Pizza
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Description = "American classic with pepperoni and mozzarella",
                    BasePrice = 1429m, // ~11 USD in KES
                    ImageUrl = "img/pizzas/pepperoni.jpg",
                    Vegetarian = false,
                    Vegan = false
                },
                new Pizza
                {
                    Id = 3,
                    Name = "Hawaiian",
                    Description = "Controversial but delicious: ham and pineapple",
                    BasePrice = 1559m, // ~12 USD in KES
                    ImageUrl = "img/pizzas/hawaiian.jpg",
                    Vegetarian = false,
                    Vegan = false
                },
                new Pizza
                {
                    Id = 4,
                    Name = "Veggie Delight",
                    Description = "Loaded with fresh vegetables and herbs",
                    BasePrice = 1299m,
                    ImageUrl = "img/pizzas/veggie.jpg",
                    Vegetarian = true,
                    Vegan = true
                },
                new Pizza
                {
                    Id = 5,
                    Name = "Meat Lovers",
                    Description = "For carnivores: pepperoni, sausage, bacon, and ham",
                    BasePrice = 1689m, // ~13 USD in KES
                    ImageUrl = "img/pizzas/meatlover.jpg",
                    Vegetarian = false,
                    Vegan = false
                },
                new Pizza
                {
                    Id = 6,
                    Name = "BBQ Chicken",
                    Description = "Grilled chicken with BBQ sauce and red onions",
                    BasePrice = 1559m,
                    ImageUrl = "img/pizzas/bbqchicken.jpg",
                    Vegetarian = false,
                    Vegan = false
                }
            };
        }
    }
}