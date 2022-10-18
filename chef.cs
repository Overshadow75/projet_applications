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
        public async Task preparePizza(Order o, Pizzeria pizzeria) {
            // check if the order is in_progress
            string pizza_list_string = "";
            if(o.State == order_type.in_progress){ 
                    Console.WriteLine("Receiving the pizza of the order " + o.OrderID);
                
                    foreach(Pizza p in o.Pizza_list) { // On parcours la liste de pizza de la commande et on les prepare
                        if(p.pizza_Size == pizza_size.small) {
                            Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                            pizza_list_string += "\t"+p.pizza_Type + "\n";
                            await Task.Delay(7000);
                            Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                        }
                        else if(p.pizza_Size == pizza_size.medium) {
                            Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                            pizza_list_string += "\t"+p.pizza_Type + "\n";
                            await Task.Delay(10000);
                            Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                        }
                        else if(p.pizza_Size == pizza_size.large) {
                            Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                            pizza_list_string += "\t"+p.pizza_Type + "\n";
                            await Task.Delay(13000);
                            Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                            
                        }
                }
                Console.WriteLine("------------------------------------\n Order "+o.OrderID +" - All the pizza are ready !\n------------------------------------");
                Console.WriteLine("avant changement : " + o.State);
                o.State = order_type.in_delivery;
                Console.WriteLine("après changement : " + o.State);
                pizzeria.Delivery_Man.deliverOrder(o);
            }
            else {
                Console.WriteLine("The order " + o.OrderID + " is not in progress");
            }
        }
    }
}