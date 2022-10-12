using System;

namespace ProjetApplication
{
    class Order
    {
        private Client c;
        private int orderID = 0;
        private DateTime hours;

        // state de la commande : in progress, finish or cancel
        private String state = "";
        List<Pizza> pizza_list = new List<Pizza>();
        List<Drink> drink_list = new List<Drink>();

        // enterOrder
        public Order(Help_cooker h, Client c) {
            this.c = c;
            Console.WriteLine("Enter the Order informations ");
            // generate orderID randomly
            Random random = new Random();
            int orderID = random.Next(1000, 9999);
            this.orderID = orderID;
            Console.WriteLine("Order ID : " + orderID);
           
            //Pizza choice
            Console.WriteLine("How many pizzas do you want ?");
            int nb_pizzas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("<======= PIZZA CHOICE =======>");
            for(int i = 0; i < nb_pizzas; i++) {
                Pizza pizza = new Pizza(i+1);
                pizza_list.Add(pizza);
            }
            
            //Drink choice
            Console.WriteLine("How many drinks do you want ?");
            int nb_drinks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("<======= DRINK CHOICE =======>");
            if(nb_drinks ==0) {
                Console.WriteLine("No drink");
            }

            
            for(int i = 0; i < nb_drinks; i++) {
                Drink drink = new Drink();
                drink_list.Add(drink);
            }

            //Validation
            Console.WriteLine("Order at : " + DateTime.Now);
            this.hours = DateTime.Now;

            Console.WriteLine("State of the order : in progress");
            this.state = "in progress";     
            int res = 0;
            res = (int)computePrice();
            Console.WriteLine("<======= ORDER VALIDATION =======>");   
            displayOrder(h, c, res);   
            // Console.WriteLine("OUOOOOUUU\n");
            // int a = 0; 
            // List<Pizza> b;
            // (a, b) =  sendOrder();
            // string pizza_list_string = "";
            // foreach(Pizza p in b) {
            //     pizza_list_string += p.pizza_Type + " ";
            // }
            // Console.WriteLine("OUIUUUUUUI" + (a,b));
            // Console.WriteLine("OUIUUUUUUI" + pizza_list_string);


        }

        // compute the price of the order
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

        // display the order
        public void displayOrder(Help_cooker h, Client c, float price) {
            int i = 1;
            Console.WriteLine("Help Cooker : " + h);
            Console.WriteLine("Order ID : " + orderID);
            Console.WriteLine("Order at : " + c.First_order);
            Console.WriteLine("Client : " + c.Name  + " " + c.Surname);
            Console.WriteLine("State of the order : " + state);
            Console.WriteLine("Pizzas ordered : ");
            foreach(Pizza p in pizza_list) {
                Console.WriteLine("pizza "+ i + " : " + p.pizza_Type);
                i++;
            }
            
            if(drink_list.Count != 0) {
                Console.WriteLine("Drinks ordered : ");
                foreach(Drink d in drink_list) {
                    Console.WriteLine("drink : " + d.drink_Type);
                }
            }
           Console.WriteLine("price : " + price + "$"); 
        }

        // send the order to cuisinier
        public Order sendOrder() {            
            return this;
        }
    }

}