using System;

namespace ProjetApplication
{
    class Drink
    {
        private drink_type drink;
        private float volume;
        private float price;
        
        public Drink() {
            Console.WriteLine("Enter the drink's informations");

            Console.WriteLine("Which drink do you want : ");
            Console.WriteLine("1 for Coca-Cola | 1$, 2 for orange juice | 2$, 3 for apple juice | 3$");
            int drink_choice = Convert.ToInt32(Console.ReadLine());
            switch(drink_choice) {
                case 0:
                    Console.WriteLine("No drink");
                    break;
                case 1:
                    drink = drink_type.coca;
                    break;
                case 2:
                    drink = drink_type.orange_juice;
                    break;
                case 3:
                    drink = drink_type.apple_juice;
                    break;
            }

            Console.WriteLine("In which volume ? : ");
            Console.WriteLine("1 for 25cl | 1$, 2 for 33cl | 2$");
            int choice_volume = Convert.ToInt32(Console.ReadLine());
            switch(choice_volume) {
                case 1:
                    volume = 25;
                    price = 1;
                    break;
                case 2:
                    volume = 33;
                    price = 2;
                    break;
            }
        }
        
        public float Price {
            get { return price; }
            set { price = value; }
        }

        // getter drink type
        public drink_type drink_Type {
            get { return drink; }
            set { drink = value; }
        }
    }  
}