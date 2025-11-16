using BlazorPizzaApp.Models;

namespace BlazorPizzaApp.Services
{
    public class PizzaService
    {
        public Task<List<PizzaSpecial>> GetSpecialsAsync()
        {
            // Simulating API call with demo data
            var specials = new List<PizzaSpecial>
            {
                new PizzaSpecial { Id = 1, Name = "Buffalo Chicken", BasePrice = 12.75m, Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up", ImageUrl = "img/pizzas/bacon.jpg" },
                new PizzaSpecial { Id = 2, Name = "The Baconatorizer", BasePrice = 11.99m, Description = "It has EVERY kind of bacon", ImageUrl = "img/pizzas/meatlover.jpg" },
                new PizzaSpecial { Id = 3, Name = "Veggie Delight", BasePrice = 11.50m, Description = "It's like salad, but on a pizza", ImageUrl = "img/pizzas/salad.jpg" },
                new PizzaSpecial { Id = 4, Name = "Mushroom Lovers", BasePrice = 11.00m, Description = "It has mushrooms. Isn't that obvious?", ImageUrl = "img/pizzas/mushroom.jpg" },
                new PizzaSpecial { Id = 5, Name = "Classic Pepperoni", BasePrice = 10.50m, Description = "It's the pizza you grew up with, but Blazing hot!", ImageUrl = "img/pizzas/pepperoni.jpg" },
                new PizzaSpecial { Id = 6, Name = "The Brit", BasePrice = 10.25m, Description = "When in London...", ImageUrl = "img/pizzas/brit.jpg" },
                new PizzaSpecial { Id = 7, Name = "Margherita", BasePrice = 9.99m, Description = "Traditional Italian pizza with tomatoes and basil", ImageUrl = "img/pizzas/margherita.jpg" },
                new PizzaSpecial { Id = 8, Name = "Hawaiian", BasePrice = 10.99m, Description = "Canadian bacon, pineapple, and cheese", ImageUrl = "img/pizzas/hawaiian.jpg" }
            };

            return Task.FromResult(specials);
        }

        public Task<List<Topping>> GetToppingsAsync()
        {
            var toppings = new List<Topping>
            {
                new Topping { Id = 1, Name = "Extra Cheese", Price = 0.50m },
                new Topping { Id = 2, Name = "Pepperoni", Price = 0.75m },
                new Topping { Id = 3, Name = "Mushrooms", Price = 0.60m },
                new Topping { Id = 4, Name = "Onions", Price = 0.40m },
                new Topping { Id = 5, Name = "Green Peppers", Price = 0.50m },
                new Topping { Id = 6, Name = "Black Olives", Price = 0.60m },
                new Topping { Id = 7, Name = "Bacon", Price = 1.00m },
                new Topping { Id = 8, Name = "Pineapple", Price = 0.70m },
                new Topping { Id = 9, Name = "Jalapeños", Price = 0.80m },
                new Topping { Id = 10, Name = "Sausage", Price = 0.90m }
            };

            return Task.FromResult(toppings);
        }

        public Task<Order> PlaceOrderAsync(Order order)
        {
            order.OrderId = Random.Shared.Next(1000, 9999);
            order.CreatedTime = DateTime.Now;
            return Task.FromResult(order);
        }

        public Task<List<OrderWithStatus>> GetOrdersAsync()
        {
            // Demo orders
            var orders = new List<OrderWithStatus>();
            return Task.FromResult(orders);
        }

        public Task<OrderWithStatus?> GetOrderWithStatusAsync(int orderId)
        {
            // Demo implementation
            return Task.FromResult<OrderWithStatus?>(null);
        }
    }
}
