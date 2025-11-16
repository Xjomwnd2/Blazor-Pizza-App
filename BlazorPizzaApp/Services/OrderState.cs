using BlazorPizzaApp.Models;

namespace BlazorPizzaApp.Services
{
    public class OrderState
    {
        public bool ShowingConfigureDialog { get; private set; }
        public OrderPizza? ConfiguringPizza { get; private set; }
        public Order Order { get; private set; } = new Order();

        public void ShowConfigurePizzaDialog(PizzaSpecial special)
        {
            ConfiguringPizza = new OrderPizza()
            {
                Special = special,
                PizzaSpecialId = special.Id,
                Size = 12,
                Toppings = new List<PizzaTopping>()
            };

            ShowingConfigureDialog = true;
        }

        public void CancelConfigurePizzaDialog()
        {
            ConfiguringPizza = null;
            ShowingConfigureDialog = false;
        }

        public void ConfirmConfigurePizzaDialog()
        {
            if (ConfiguringPizza != null)
            {
                Order.Pizzas.Add(ConfiguringPizza);
                ConfiguringPizza = null;
            }

            ShowingConfigureDialog = false;
        }

        public void RemoveConfiguredPizza(OrderPizza pizza)
        {
            Order.Pizzas.Remove(pizza);
        }

        public void ResetOrder()
        {
            Order = new Order();
        }
    }
}
