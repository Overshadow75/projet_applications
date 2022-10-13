using System;

namespace ProjetApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Pizzeria pizzeria = new Pizzeria();
            Client c = new Client(1, "John", "Doe", 1, "1234567890", DateTime.Now, 1, "rue de la paix", "Paris", "75000", "France");
            Help_cooker h = new Help_cooker(009, "Pierre", "Chabrieux", 2);
            Chef c1 = new Chef(1, "Jean", "Dupont", 3);
            pizzeria.addClient(c);

            h.isFirstTimeOrder(c, pizzeria);
            //pizzeria.printOrderList(); // print order list from pizzeria

            
        }

    }
}
