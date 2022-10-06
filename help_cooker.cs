using System;

namespace ProjetApplication
{
    class Help_cooker : Person
    { 
        // liste de commande
        private List<Order> command_list = new List<Order>();

        // constructor
        public Help_cooker(int personID, string name, string surname, int metierID) : base(personID, name, surname, metierID) 
        {}
        public void isFirstTimeOrder(Client c, Pizzeria p ) {
            Console.WriteLine("is it the first time you order? (y/n)");

            string choiceClient = Console.ReadLine(); //First time ? Client answer

            if (choiceClient == "n") { //Case - Not the first time
                Console.WriteLine("Not the first time time");
                Console.WriteLine("Verification of the phone number");
                
                string phone = Console.ReadLine();
                if(p.isClientInList(phone)) { //Verification of the phone number
                    Console.WriteLine("Client is in the list");
                    
                    c.printAddress();
                    Console.WriteLine("Is it your address ? (y/n)");
                    String addressConfirmation = Console.ReadLine();

                    if (addressConfirmation == "y") { //Case - Good address
                        Console.WriteLine("Good Address");
                    } else if (addressConfirmation == "n") { //Case - Bad address
                        Console.WriteLine("Enter the correct address :");
                        c.enterAddress();
                        Console.WriteLine("AFFICHAGE APRES : ");
                        c.printAddress();
                    }
                } else { //Case - Client is not in the list
                    Console.WriteLine("Client is not in the list");
                    Console.ReadLine();
                }
            }
            else if(choiceClient == "y")  { //Case - The first time
                Console.WriteLine("First time");
                c.enterClient();
            }
        }

        public void getClientOrder(bool isFirstTimeOrder, Order order) {
            // mettre la commande dans la liste de commande
            command_list.Add(order);
        }
    }
}