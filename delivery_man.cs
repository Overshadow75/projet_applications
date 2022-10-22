using System;
using System.Threading;

namespace ProjetApplication
{
    class Delivery_man : Person
    {
        //CONSTRUCTORS
        public Delivery_man(){}
        
        //FUNCTIONS
        // Function to deliver the order
        public async void deliverOrder(Order o, Pizzeria pizzeria) {
            
            // Check if the order has been properly prepared by the chef (in_delivery)
            if(o.State == order_type.in_delivery) {
                await Task.Delay(10000);
                Console.WriteLine("------------------------------------\n Order "+o.OrderID +" - All the pizza are ready !\n------------------------------------");
                
                Console.WriteLine("Order in delivery");
                await Task.Delay(2000);
                Console.WriteLine("Sending the order " + o.OrderID + " to the client ");
                
                // Once the order is delivered, the order is ready to be paid (in_delivery -> delivered)
                o.State = order_type.delivered;
                
                //Ckeck if the order is properly delivered
                if(o.State == order_type.delivered) {
                    Console.WriteLine("The address was found");
                    Console.WriteLine("-------------------------------\n The order " + o.OrderID + " is delivered \n-------------------------------");
                    Console.WriteLine("Deliver received : " + o.computePrice() + "€");
                    await Task.Delay(5000);
                    
                    // Once the order is paid, the order is ready to be cashed by the help_cooker
                    pizzeria.Help_cooker.endOrder(o, pizzeria);
                    o.displayOrder();
                }
            }
        }

    }
}


