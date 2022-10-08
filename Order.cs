using System;

namespace ProjetApplication
{
    abstract class Order
    {
        private int orderID = 0;
        private DateTime hours;
        // private Client client = new Client();
        // private Help_cooker help_cooker = new Help_cooker();
        // state de la commande : in progress, finish or cancel
        private String state = "";
        List<Pizza> pizza_list = new List<Pizza>();
        List<Drink> drink_list = new List<Drink>();

        //constructor
        // public Order(int orderID, DateTime hours, Help_cooker help_cooker, Boolean state, Pizza[] pizzas, Drink[] drinks) {
        //     this.orderID = orderID;
        //     this.hours = hours;
        //     // this.help_cooker = help_cooker;
        //     this.state = state;
        //     this.pizzas = pizzas;
        //     this.drinks = drinks;
        // }

        // enterOrder
        public Order() {
            Console.WriteLine("Enter the Order informations");

            Console.WriteLine("Order ID : ");
            // generate orderID randomly
            Random random = new Random();
            int orderID = random.Next(1000, 9999);
            this.orderID = orderID;

            //Pizza choice
            Console.WriteLine("How many pizzas do you want ?");
            int nb_pizzas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the pizza's informations");
            for(int i = 0; i < nb_pizzas; i++) {
                Pizza pizza = new Pizza();
                pizza_list.Add(pizza);

            }

            
            //Drink choice
            Console.WriteLine("How many drinks do you want ?");
            int nb_drinks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the drink's informations");
            for(int i = 0; i < nb_drinks; i++) {
                Drink drink = new Drink();
                drink_list.Add(drink);
            }


            //Validation
            Console.WriteLine("Order at : " + DateTime.Now);
            DateTime hours = DateTime.Now;

            Console.WriteLine("State : in progress");
            this.state = "in progress";
        }


        
    }

}