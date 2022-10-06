using System;

namespace ProjetApplication
{
    class Order
    {
        private int orderID = 0;
        private DateTime hours;
        // private Client client = new Client();
        // private Help_cooker help_cooker = new Help_cooker();
        private Boolean state = false;
        private Pizza[] pizzas = new Pizza[10];
        private Drink[] drinks = new Drink[10];

        //constructor
        public Order(int orderID, DateTime hours, Help_cooker help_cooker, Boolean state, Pizza[] pizzas, Drink[] drinks) {
            this.orderID = orderID;
            this.hours = hours;
            // this.help_cooker = help_cooker;
            this.state = state;
            this.pizzas = pizzas;
            this.drinks = drinks;
        }

        // enterOrder
        public void enterOrder() {
            Console.WriteLine("Enter the order's informations");

            Console.WriteLine("Order ID : ");
            int orderID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours : ");
            DateTime hours = DateTime.Now;

            Console.WriteLine("State : ");
            Boolean state = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Pizzas : ");
            Pizza[] pizzas = new Pizza[10];
            for(int i = 0; i < 10; i++) {
                pizzas[i] = new Pizza();
                pizzas[i].enterPizza();
            }

            Console.WriteLine("Drinks : ");
            Drink[] drinks = new Drink[10];
            for(int i = 0; i < 10; i++) {
                drinks[i] = new Drink();
                drinks[i].enterDrink();
            }
        }
        
    }

}