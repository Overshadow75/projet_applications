using System;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 8600
namespace ProjetApplication
{
    class Help_cooker : Person
    { 
        // Attributes
        
    

        // Constructor
        public Help_cooker(int personID, string name, string surname, int metierID) : base(personID, name, surname, metierID) 
        {}

        public async void enterOrder(Pizzeria p) {
            Console.WriteLine("------------------------------------\nIs it the first time you order? (y/n)\n------------------------------------");
            string choiceClient = Console.ReadLine(); //First time ? Client answer
            
            choiceClient = choiceClient == "" ? "n" : choiceClient; // Development purpose

            while(choiceClient != "y" && choiceClient != "n") {
                Console.WriteLine("Please answer y or n");
                choiceClient = Console.ReadLine();
            }
            
            if (choiceClient == "n") { //Case - Not the first time
                Console.WriteLine("Not the first time");
                Console.WriteLine("Verification of the phone number");
                
                string phone = Console.ReadLine();//Input of the phone number

                phone = phone == "" ? "1234567890" : phone; // Development purpose
                
                if(p.isClientInList(phone)) { //Case - Client is in the list
                    Console.WriteLine("Client is in the list");

                    Client c = p.getClient(phone);                 

                    Console.WriteLine("-------------------------\nIs it your address ? [y/n]\n-------------------------");
                    // TODO: fonction qui cherche les clients avec le meme numero de telephone et adresse
                    

                    String addressConfirmation = Console.ReadLine(); //Answer of the Client

                    addressConfirmation = addressConfirmation == "" ? "y" : addressConfirmation; // Development purpose

                    if (addressConfirmation == "y") { //Case - Good address
                        Console.WriteLine("Good Address");

                        String readyToCommand = "";

                        do{
                            Console.WriteLine("--------------------------\nAre you ready to command ? \n--------------------------");
                            while(readyToCommand != "y" && readyToCommand != "n") {
                                Console.WriteLine("Enter [y/n]");
                                readyToCommand = Console.ReadLine();
                            }
                
                            if (readyToCommand == "y") { //Case - Client is ready to command
                                Console.WriteLine("<======Take the order======>"); //Prise de commande
                                Order order = new Order(this, c);
                                //add order to the list of order which is in the pizzeria
                                p.addOrder(order);
                                
                                p.Chef.preparePizza(order, p);
                                
                                //Take another client's order 
                                Task t2 = Task.Run(() => p.Help_cooker.enterOrder(p)); 
                                t2.Wait();
                            }
                            Task t1 = Task.Run(() => p.Help_cooker.enterOrder(p)); 
                            t1.Wait();
                            
                            await Task.Delay(6000);
                        } while(readyToCommand != "n");

                    } else if (addressConfirmation == "n") { //Case - Bad address
                        Console.WriteLine("Collecting Client's information"); //First time OR Not in the list
                        Client cO = new Client();
                        p.addClient(cO);
  
                        Console.WriteLine("<======Take the order======>"); //Prise de commande
                        Order order = new Order(this, c);
                    }
                }

            } else if(choiceClient == "y")  { //Case - The first time OR Not in the list
                Console.WriteLine("Collecting Client's information"); //First time OR Not in the list
                Client c0 = new Client();
                p.addClient(c0);
                Console.WriteLine("<======Take the order======>"); //Prise de commande
                Order order = new Order(this, c0);
                p.addOrder(order);
                p.Chef.preparePizza(order, p);
                Task t = Task.Run(() => p.Help_cooker.enterOrder(p)); //Task to run the method in parallel
                t.Wait();
            }
        }
    }
}