using System;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 8600, 8604
namespace ProjetApplication
{
    class Help_cooker : Person
    { 
        // CONSTRUCTORS
        public Help_cooker(int personID, string name, string surname, int metierID) : base(personID, name, surname, metierID) 
        {}

        // FUNCTIONS
        // Async function that enter the Order
        public async void enterOrder(Pizzeria p) {
            
            // First time of the Client ?
            Console.WriteLine("------------------------------------\nIs it the first time you order? (y/n)\n------------------------------------");
            string choiceClient = Console.ReadLine();
            
            choiceClient = choiceClient == "" ? "n" : choiceClient; // Simplify the input. Just press enter to say no.

            while(choiceClient != "y" && choiceClient != "n") {
                Console.WriteLine("Please answer y or n");
                choiceClient = Console.ReadLine();
            }
            
            //CASE - Not the first time
            if (choiceClient == "n") { 
                Console.WriteLine("Not the first time");
                
                // Phone verification to see if the client is already in the 'database'
                Console.WriteLine("Verification of the phone number");
                string phone = Console.ReadLine();

                phone = phone == "" ? "1234567890" : phone; // Development purpose
                
                //CASE - Client is in the list
                if(p.isClientInList(phone)) { 
                    Console.WriteLine("Client is in the list");

                    Client c = p.getClient(phone); // Get the client from the list

                    // Address verification
                    Console.WriteLine("-------------------------\nIs it your address ? [y/n]\n-------------------------");
                    
                    String addressConfirmation = Console.ReadLine();

                    addressConfirmation = addressConfirmation == "" ? "y" : addressConfirmation; // Development purpose

                    //CASE - Address is correct
                    if (addressConfirmation == "y") { 
                        Console.WriteLine("Good Address");

                        // Checking if the Client is ready to order
                        String readyToCommand = "";

                        do{
                            Console.WriteLine("--------------------------\nAre you ready to command ? \n--------------------------");
                            while(readyToCommand != "y" && readyToCommand != "n") {
                                Console.WriteLine("Enter [y/n]");
                                readyToCommand = Console.ReadLine();
                            }
                
                            //CASE - Client is ready to command
                            if (readyToCommand == "y") { 
                                // Take the order
                                Console.WriteLine("<======Take the order======>");
                                Order order = new Order(this, c);
                                p.addOrder(order); // Add the order to the list of orders
                                
                                //Order sent to the Chef
                                p.Chef.preparePizzas(order, p);
                                
                                //Take another client's order 
                                Task t2 = Task.Run(() => p.Help_cooker.enterOrder(p)); 
                                t2.Wait();
                            }

                            //CASE - Client is not ready to command
                            // Take another client's order
                            Task t1 = Task.Run(() => p.Help_cooker.enterOrder(p)); 
                            t1.Wait();
                            
                            await Task.Delay(6000);
                        } while(readyToCommand != "n");
                    
                    //CASE - Address is not correct
                    } else if (addressConfirmation == "n") { 
                        // Create a new Client
                        Console.WriteLine("Collecting Client's information");
                        Client cO = new Client();
                        p.addClient(cO); // Add the client to the list of clients
  
                        // Take the order
                        Console.WriteLine("<======Take the order======>");
                        Order order = new Order(this, c);

                        // Order sent to the Chef
                        p.Chef.preparePizzas(order, p);

                        // Take another client's order
                        Task t = Task.Run(() => p.Help_cooker.enterOrder(p)); //Task to run the method in parallel
                        t.Wait();
                    }
                }
            
            //CASE - First time OR Not in the list
            } else if(choiceClient == "y")  { 
                // Create a new Client
                Console.WriteLine("Collecting Client's information");
                Client c0 = new Client();
                p.addClient(c0);

                // Take the order
                Console.WriteLine("<======Take the order======>"); //Prise de commande
                Order order = new Order(this, c0);
                p.addOrder(order);

                // Order sent to the Chef
                p.Chef.preparePizzas(order, p);

                // Take another client's order
                Task t = Task.Run(() => p.Help_cooker.enterOrder(p)); //Task to run the method in parallel
                t.Wait();
            }
        }

        // Function that end an Order
        public void endOrder(Order o, Pizzeria p) {
            Console.WriteLine("Money cashed : " + o.computePrice() + "€");

            // Money add to the Treasury
            p.addToTreasury(o.computePrice());
            Console.WriteLine("Treasury : " + p.Treasury + "€");

            // Once the order is finished, change the status of the order (delivered -> finished)
            o.State = order_type.finished;
            Console.WriteLine("-------------------------\n Order " + o.OrderID + " finished \n-------------------------");
        }

    }
}