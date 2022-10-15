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
            Help_cooker h = new Help_cooker(009, "Pierre", "Chabrieux", 2);
            Chef c1 = new Chef(1, "Jean", "Dupont", 3);
            pizzeria.addClient(c);

            //Task take_client  = Task.Run(() => h.isFirstTimeOrder(c, pizzeria));
            Task t1 = Task.Run(() => h.isFirstTimeOrder(c, pizzeria));

            //pizzeria.printOrderList(); // print order list from pizzeria
            //Task t2 = Task.Run(() => c1.preparePizza(pizzeria.returnOrder()));            



            //Console.WriteLine("Pizza is ready");


            // Printing In progress each 3 seconds
            int i = 0;
            while(i < 10){
                Console.WriteLine("Working");
                Task t2 = Task.Run(() => c1.preparePizza(pizzeria.returnOrder()));            
                Task.Delay(10000).Wait();
                i++;				
            }
        }

    }
}
