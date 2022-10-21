using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetApplication
{
    class Chef : Person
    {
         public Chef(int personID, string name, string surname, int metierID) : base(personID, name, surname, metierID) {
        }
        // async function that prepare the pizza
        public void preparePizzas(Order o, Pizzeria pizzeria) {
            // check if the order is in_progress
            string pizza_list_string = "";
            if(o.State == order_type.in_progress){ 
                Console.WriteLine("Receiving the pizza of the order " + o.OrderID);
                
                // run a task for each pizza in the order to prepare it
                foreach(Pizza pizza in o.Pizza_list) {
                    pizza_list_string += pizza.pizza_Type + " ";
                    Task.Run( () => makingPizza(pizza, o));
                }
                
            }
            o.State = order_type.in_delivery;
            pizzeria.Delivery_Man.deliverOrder(o, pizzeria);
        }

        public async void makingPizza(Pizza pizza, Order o) {
            // selon la taille de la pizza, on attend un temps différent
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