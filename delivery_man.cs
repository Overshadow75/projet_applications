using System;

namespace ProjetApplication
{
    class Delivery_man 
    {
        public async Task deliverOrder(Order o) {
            Console.WriteLine("Order in delivery");
            if(o.State == order_type.in_delivery) {
                Console.WriteLine("Sending the order " + o.OrderID + " to the client ");
                await Task.Delay(3000);
                o.State = order_type.delivered;
                if(o.State == order_type.delivered) {
                    Console.WriteLine("The order " + o.OrderID + " is delivered");
                }
            }
        }
    }
}
