using System;

namespace ProjetApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // TEST A FAIRE A LA FIN
            // create a client by inputing his informations
            // Console.WriteLine("Enter the client's informations");

            // Console.WriteLine("Person ID : ");
            // int personID = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Name : ");
            // string name = Console.ReadLine();

            // Console.WriteLine("Surname : ");
            // string surname = Console.ReadLine();

            // Console.WriteLine("1 for employee, 2 for client ");
            // Console.WriteLine("Metier ID : ");
            // int metierID = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Phone : ");
            // string phone = Console.ReadLine();

            // TEST RAPIDE
            Pizzeria pizzeria = new Pizzeria();
            Client c = new Client(1, "John", "Doe", 1, "1234567890", DateTime.Now, 1, "rue de la paix", "Paris", "75000", "France");
            // Help_cooker h1 = new Help_cooker();
            Help_cooker h = new Help_cooker(009, "Pierre", "Chabrieux", 2);
            pizzeria.addClient(c);

            h.isFirstTimeOrder(c, pizzeria);

        }

    }
}
