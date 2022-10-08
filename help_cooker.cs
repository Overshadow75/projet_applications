using System;

namespace ProjetApplication
{
    class Help_cooker : Person
    { 
        // Attributes
        private List<Order> command_list = new List<Order>();

        // Constructor
        public Help_cooker(int personID, string name, string surname, int metierID) : base(personID, name, surname, metierID) 
        {}

        //Getter & Setter
        public void getClientOrder(bool isFirstTimeOrder, Order order) {
            // mettre la commande dans la liste de commande
            command_list.Add(order);
        }


        //Greetings
        public void isFirstTimeOrder(Client c, Pizzeria p) {
            Console.WriteLine("is it the first time you order? (y/n)");

            string choiceClient = Console.ReadLine(); //First time ? Client answer

            if (choiceClient == "n") { //Case - Not the first time
                Console.WriteLine("Not the first time");
                Console.WriteLine("Verification of the phone number");
                
                string phone = Console.ReadLine();//Input of the phone number

                if(p.isClientInList(phone)) { //Case - Client is in the list
                    Console.WriteLine("Client is in the list");
                    
                    c.printAddress();
                    Console.WriteLine("Is it your address ? (y/n)");
                    String addressConfirmation = Console.ReadLine(); //Answer of the Client

                    if (addressConfirmation == "y") { //Case - Good address
                        Console.WriteLine("Good Address");
                        Console.WriteLine("<======Take the order======>"); //Prise de commande
                        
                    } else if (addressConfirmation == "n") { //Case - Bad address
                        Console.WriteLine("Enter the correct address :"); //Updating address
                        c.enterAddress();
                        Console.WriteLine("AFFICHAGE APRES : ");
                        c.printAddress();
                        Console.WriteLine("<======Take the order======>"); //Prise de commande
                        
                    }
                }

            } else if(choiceClient == "y")  { //Case - The first time OR Not in the list
                Console.WriteLine("Collecting Client's information"); //First time OR Not in the list
                c.enterClient();
                Console.WriteLine("<======Take the order======>"); //Prise de commande
                // Créer une Order qui sera liée au Client
            }
        }


        //Pizza command


        //Drink command



        //General command





    }
}