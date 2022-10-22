using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Clear();

            Pizzeria pizzeria = new Pizzeria();
            
            Client c = new Client(1, "John", "Doe", 1, "1234567890", DateTime.Now, 1, "rue de la paix", "Paris", "75000", "France");
            
            pizzeria.addClient(c);

            //set h as Help_Cooker
            pizzeria.Help_cooker = new Help_cooker(9, "Pierre", "Chabrier", 2);

            // set chef to pizzeria
            pizzeria.Chef = new Chef(1, "Jean", "Dupont", 3); 

            //set delivery_man to pizzeria
            pizzeria.Delivery_Man = new Delivery_man();            

            // Run the Task
            Task t1 = Task.Run(() => pizzeria.Help_cooker.enterOrder(pizzeria));        
            await t1;
        }
    }
}
