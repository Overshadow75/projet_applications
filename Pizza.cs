using System;

namespace ProjetApplication
{
    class Pizza
    {
        private pizza_size size;
        private pizza_type type;
        private float price;


        public void enterPizza() {
            Console.WriteLine("Enter the pizza's informations");

            Console.WriteLine("Size : ");
            // TODO : enum et faire des conditions pour chaque taille
            this.size = pizza_size.medium;
            
            Console.WriteLine("Name : ");
            // TODO : enum et faire des conditions pour chaque pizza
            this.type = pizza_type.margherita;

            Console.WriteLine("Price : ");
            this.price = Convert.ToSingle(Console.ReadLine());

        }
    }
}