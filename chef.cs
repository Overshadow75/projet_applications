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
        public async Task preparePizzas(Order o, Pizzeria pizzeria) {
            // check if the order is in_progress
            string pizza_list_string = "";
            if(o.State == order_type.in_progress){ 
                Console.WriteLine("Receiving the pizza of the order " + o.OrderID);
                
                Parallel.ForEach(o.Pizza_list, async p => {
                    if(p.pizza_Size == pizza_size.small) {
                        Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                        pizza_list_string += "\t"+p.pizza_Type + "\n";
                        await Task.Delay(5000);
                        Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                    }
                    else if(p.pizza_Size == pizza_size.medium) {
                        Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                        pizza_list_string += "\t"+p.pizza_Type + "\n";
                        Thread.Sleep(10000);
                        Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                    }
                    else if(p.pizza_Size == pizza_size.large) {
                        Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                        pizza_list_string += "\t"+p.pizza_Type + "\n";
                        Thread.Sleep(15000);
                        Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                        
                    }
                });

                // a chaque fois que j 'ajoute une pizza , on appelle une fonction en task . run qui va attendre 5 secondes et afficher que la pizza est prête

                // foreach(Pizza p in o.Pizza_list) { // On parcours la liste de pizza de la commande et on les prepare
                //     if(p.pizza_Size == pizza_size.small) {
                //         Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                //         pizza_list_string += "\t"+p.pizza_Type + "\n";
                //         await Task.Delay(7000);
                //         Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                //     }
                //     else if(p.pizza_Size == pizza_size.medium) {
                //         Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                //         pizza_list_string += "\t"+p.pizza_Type + "\n";
                //         await Task.Delay(10000);
                //         Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                //     }
                //     else if(p.pizza_Size == pizza_size.large) {
                //         Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                //         pizza_list_string += "\t"+p.pizza_Type + "\n";
                //         await Task.Delay(13000);
                //         Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
                        
                //     }

                //     Task.Run(() => prepareSmallPizza(p)); 
                    
                //     Task.Run(() => prepareMediumPizza(p)); 
                    
                //     Task.Run(() => prepareLargePizza(p)); 
                //     // wait all the task to finish
                //     await Task.WhenAll();
                //     // t1.Wait();
                //     // t2.Wait();
                //     // t3.Wait();
                // }

                Console.WriteLine("------------------------------------\n Order "+o.OrderID +" - All the pizza are ready !\n------------------------------------");
                o.State = order_type.in_delivery;
                pizzeria.Delivery_Man.deliverOrder(o, pizzeria);
            }
            else {
                Console.WriteLine("The order " + o.OrderID + " is not in progress");
            }
        }

        public async void prepareSmallPizza(Pizza p){
            string pizza_list_string = "";

            if(p.pizza_Size == pizza_size.small) {
                Console.WriteLine("Preparing the small " + p.pizza_Type + " pizza");
                pizza_list_string += "\t"+p.pizza_Type + "\n";
                await Task.Delay(7000);
                Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
            }
        }

        public async void prepareMediumPizza(Pizza p){
            string pizza_list_string = "";
            
            if(p.pizza_Size == pizza_size.medium) {
                Console.WriteLine("Preparing the medium " + p.pizza_Type + " pizza");
                pizza_list_string += "\t"+p.pizza_Type + "\n";
                await Task.Delay(10000);
                Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
            }
        }

        public async void prepareLargePizza(Pizza p){
            string pizza_list_string = "";
            
            if(p.pizza_Size == pizza_size.large) {
                Console.WriteLine("Preparing the large " + p.pizza_Type + " pizza");
                pizza_list_string += "\t"+p.pizza_Type + "\n";
                await Task.Delay(13000);
                Console.WriteLine("Pizza " + p.pizza_Type + " is ready\n");
            }
        }


                        // a chaque fois que j 'ajoute une pizza , on appelle une fonction en task . run qui va attendre 5 secondes et afficher que la pizza est prête

    }
}