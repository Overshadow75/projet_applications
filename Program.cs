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
            //Soit ajouter la liste de client de l'extérieur soit la créer dans la pizzeria
            Client c = new Client(1, "John", "Doe", 1, "1234567890", DateTime.Now, 1, "rue de la paix", "Paris", "75000", "France");
            //Help_cooker h = new Help_cooker(009, "Pierre", "Chabrieux", 2);
            //Chef c1 = new Chef(1, "Jean", "Dupont", 3);
            pizzeria.addClient(c);

            //set h as Help_Cooker
            pizzeria.Help_cooker = new Help_cooker(009, "Pierre", "Chabrieux", 2);

            // set chef to pizzeria
            pizzeria.Chef = new Chef(1, "Jean", "Dupont", 3);            

            Task t1 = Task.Run(() => pizzeria.Help_cooker.enterOrder(c, pizzeria));        
            await t1;
            //  while(!t1.IsCompleted){};
            // if(t1.IsCompleted){
            //     Task t2 = Task.Run(() => pizzeria.Chef.preparePizza(pizzeria.returnOrder()));            
            //     // task 2 is async, wait for it to complete
            
            //     // restart t1
            //     t1 = Task.Run(() => pizzeria.Help_cooker.enterOrder(c, pizzeria));
            // }
        }
    }
}
