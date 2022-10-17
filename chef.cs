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
        public async Task preparePizza(Order o) {
            // check if the order is in_progress
           if(o.State == order_type.in_progress){ 
                Console.WriteLine("Receiving the pizza of the order " + o.OrderID);
                Console.WriteLine("Entre While");
               
                foreach(Pizza p in o.Pizza_list) { // On parcours la liste de pizza de la commande et on les prepare
                    
                    string pizza_list_string = "";
                    Console.WriteLine("=====\n Preparing the pizza : " + p.pizza_Type);
                    pizza_list_string += "\t"+p.pizza_Type + "\n";
                    await Task.Delay(3000);
                    Console.WriteLine("Pizza " + p.pizza_Type + " is ready"); 
                }
                Console.WriteLine("=====\n All the pizza are ready (order " + o.OrderID+")");
                o.State = order_type.in_delivery;
            }
            else {
                Console.WriteLine("The order " + o.OrderID + " is not in progress");
            }
        }
    }
}
