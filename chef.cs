using System;

namespace ProjetApplication
{
    class Chef : Person
    {
        public Chef(int personID, string name, string surname, int metierID) : base(personID, name, surname, metierID) {
        }
        // async function that prepare the pizza
        public async void preparePizza(Order o) {

            Console.WriteLine("Receiving the pizza");
            string pizza_list_string = "";
            foreach(Pizza p in o.Pizza_list) {
                // async function that print each pizza 
                Console.WriteLine("preparing the pizza : " + p.pizza_Type);
                pizza_list_string += p.pizza_Type + " ";
                await Task.Delay(1000);
                // async function that print the pizza
                Console.WriteLine("Pizza " + p.pizza_Type + " is ready");
                Console.WriteLine("String pizza list : " + pizza_list_string);
            }
        }
    }
}