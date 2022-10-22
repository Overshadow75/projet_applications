using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetApplication
{
    class Chef : Person
    {
        // CONSTRUCTORS
        public Chef(int personID, string name, string surname, int metierID) : base(personID, name, surname, metierID) {
        }

        // FUNCTIONS
        // Async function that prepare all the Pizzas
        public void preparePizzas(Order o, Pizzeria pizzeria) {
            string pizza_list_string = "";

            // Check if the order has been properly taken by the help_cooker (in_progress)
            if(o.State == order_type.in_progress){ 
                Console.WriteLine("Receiving the pizza of the order " + o.OrderID);
                
                // Run a task for each Pizza in the Order to prepare it asynchronously
                foreach(Pizza pizza in o.Pizza_list) {
                    pizza_list_string += pizza.pizza_Type + " ";
                    Task.Run( () => makingPizza(pizza, o));
                }
                
            }
            // Once all the pizzas are prepared, the order is ready to be delivered (in_progress -> in_delivery)
            o.State = order_type.in_delivery;
            pizzeria.Delivery_Man.deliverOrder(o, pizzeria);
        }

        // Async function that prepare each Pizza
        public async void makingPizza(Pizza pizza, Order o) {
            // We wait a different delay depending on the Pizza_size
            switch(pizza.pizza_Size) {
                case pizza_size.small:
                    Console.WriteLine("Making the pizza " + pizza.pizza_Type);
                    await Task.Delay(5000);
                    Console.WriteLine("Pizza " + pizza.pizza_Type + " is ready");
                break;
                case pizza_size.medium:
                    Console.WriteLine("Making the pizza " + pizza.pizza_Type);
                    await Task.Delay(7000);
                    Console.WriteLine("Pizza " + pizza.pizza_Type + " is ready");
                break;
                case pizza_size.large:
                    Console.WriteLine("Making the pizza " + pizza.pizza_Type);
                    await Task.Delay(9000);
                    Console.WriteLine("Pizza " + pizza.pizza_Type + " is ready");
                break;
            }
        }

    }
}