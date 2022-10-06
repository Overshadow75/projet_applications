using System;

namespace ProjetApplication
{
    class Help_cooker
    { 
        // liste de commande
        private List<Order> command_list = new List<Order>();
        public void isFirstTimeOrder(Client c, int choice, Pizzeria p ) {
            Console.WriteLine("is it the first time you order?");
            if (choice == 1) {
                Console.WriteLine("Not the first time time");
                // ask phone and see if is in the client list
                if(p.isClientInList(c.Phone)) {
                    Console.WriteLine("Client is in the list");
                    
                }
                else {
                    Console.WriteLine("Client is not in the list");
                }
               


            }
            else { 
                Console.WriteLine("First time");              
            }
                 
           
        }

        
        public void getClientOrder(bool isFirstTimeOrder, Order order) {
            // mettre la commande dans la liste de commande
            command_list.Add(order);
        }


    }
}