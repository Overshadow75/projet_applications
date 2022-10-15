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
        public async void preparePizza(Order o) {
            var loop = true;
            Console.WriteLine("Receiving the pizza of the order " + o.OrderID);
            Console.WriteLine("Entre While");
            await Task.Delay(3000);
            while(loop) {
                if(o.State == order_type.in_progress){ // si l'etat de la commande est en cours
                    foreach(Pizza p in o.Pizza_list) { // On parcours la liste de pizza de la commande et on les prepare
                        
                        string pizza_list_string = "";

                        Console.WriteLine("pizza_list_string : \n" + pizza_list_string);
                        // async function that print each pizza 
                        Console.WriteLine("Preparing the pizza : " + p.pizza_Type);
                        // async function that print the pizza
                        pizza_list_string += "\t"+p.pizza_Type + "\n";
                        Console.WriteLine("Pizza " + p.pizza_Type + " is ready"); 
                    }
                    loop = false;
                    //CHANGER STATE EN ORDERED
                    Console.WriteLine("Sorti Forceach");
                }
                Console.WriteLine("Sorti IF");
            }
        }
    }
}