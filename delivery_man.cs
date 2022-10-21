using System;
using System.Threading;

namespace ProjetApplication
{
    class Delivery_man : Person
    {
        public Delivery_man(){}
        public async void deliverOrder(Order o, Pizzeria pizzeria) {

            if(o.State == order_type.in_delivery) {
                await Task.Delay(10000);
                Console.WriteLine("------------------------------------\n Order "+o.OrderID +" - All the pizza are ready !\n------------------------------------");
                Console.WriteLine("Order in delivery");
                await Task.Delay(2000);
                Console.WriteLine("Sending the order " + o.OrderID + " to the client ");
                o.State = order_type.delivered;
                if(o.State == order_type.delivered) {
                    Console.WriteLine("The address was found");
                    Console.WriteLine("The order " + o.OrderID + " is delivered");
                    Console.WriteLine("Deliver received : " + o.computePrice() + "€");
                    await Task.Delay(5000);
                    pizzeria.Help_cooker.endOrder(o, pizzeria);
                    o.displayOrder();
                }
                // TODO mettre en parametre la liste des commandes et les livrer
            }
        }
    }
}


