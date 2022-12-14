using System;

namespace ProjetApplication
{
    class Order
    {
        // ATTRIBUTES
        private Client c;
        public static int nOrders = 0;
        private int orderID = 0;
        private DateTime hours;

        // Order state (in_progress, in_delivery, delivered, finished, canceled)
        private order_type state = order_type.in_progress; // by default the order is in progress 
        
        // Creation of lists
        List<Pizza> pizza_list = new List<Pizza>(); // list of pizza
        List<Drink> drink_list = new List<Drink>(); // list of drink
        
        // CONSTRUCTORS
        // enterOrder() use the constructor
        public Order(Help_cooker h, Client c) { 
            this.c = c;            
            nOrders ++;
            this.orderID = nOrders;
            Console.WriteLine("------------\nOrder n°" + orderID +"\n------------");
           
            //Pizza choice
            int nb_pizzas;
            Console.WriteLine("How many pizzas ?");
            Console.WriteLine("Enter a number [max 5]");

            while (!int.TryParse(Console.ReadLine(), out nb_pizzas) || nb_pizzas > 5) {
                Console.WriteLine("Enter a number [max 5]");
            }
            Console.WriteLine("<======= PIZZA CHOICE =======>");
            for(int i = 0; i < nb_pizzas; i++) {
                Pizza pizza = new Pizza(i+1);
                pizza_list.Add(pizza);
            }
            
            //Drink choice
            Console.WriteLine("How many drinks ?");
            Console.WriteLine("Enter a number [max 5]");
            int nb_drinks;
            while (!int.TryParse(Console.ReadLine(), out nb_drinks) || nb_drinks > 5) {
                Console.WriteLine("Enter a number [max 5]");
            }
            Console.WriteLine("<======= DRINK CHOICE =======>");
            if(nb_drinks ==0) {
                Console.WriteLine("No drink");
            }

            
            for(int i = 0; i < nb_drinks; i++) {
                Drink drink = new Drink();
                drink_list.Add(drink);
            }

            //Validation
            Console.WriteLine("---------------------------------\nOrder take at " + DateTime.Now + "\n---------------------------------");
            this.hours = DateTime.Now;

            Console.WriteLine("State of the order : in progress");
             
            int res = 0;
            res = (int)computePrice();
        }

        // GETTERS AND SETTERS
        public List<Pizza> Pizza_list {
            get { return pizza_list; }
            set { pizza_list = value; }
        }

        public int OrderID {
            get => orderID;
            set => orderID = value;
        }

        public order_type State {
            get => state;
            set => state = value;
        }

        //FUNCTIONS
        // Function that compute the total price of the Order
        public float computePrice() {
            float price = 0;
            foreach(Pizza pizza in pizza_list) {
                price += pizza.Price;
            }
          
            foreach(Drink drink in drink_list) {
                price += drink.Price;
            }
            return price;
        }

        // Function that display the Order
        public void displayOrder() {
            int i = 1;
            Console.WriteLine("Order ID : " + orderID);
            Console.WriteLine("State of the order : " + state);
            Console.WriteLine("Pizzas ordered : ");
            foreach(Pizza p in pizza_list) {
                Console.WriteLine("\tpizza "+ i + " : " + p.pizza_Type);
                i++;
            }
            
            if(drink_list.Count != 0) {
                Console.WriteLine("Drinks ordered : ");
                foreach(Drink d in drink_list) {
                    Console.WriteLine("\tdrink : " + d.drink_Type);
                }
            }
        }

    }
}