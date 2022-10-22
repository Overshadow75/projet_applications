using System;

namespace ProjetApplication
{
    class Drink
    {
        // ATTRIBUTES
        private drink_type drink;
        private float volume;
        private float price;
        
        // CONSTRUCTORS
        public Drink() {
            Console.WriteLine("Which drink do you want : ");
            Console.WriteLine("--------------------\n1 Coca-Cola     [1€] \n2 Orange juice  [2€] \n3 Apple juice   [3€]\n--------------------");
            
            int drink_choice;

            // Choice of the drink_type
            while (!int.TryParse(Console.ReadLine(), out drink_choice) || drink_choice > 3 || drink_choice < 1) {
                Console.WriteLine("Enter a number [1, 2 or 3]");
            }
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
            
            // Choice of the volume
            Console.WriteLine("Volume : ");
            Console.WriteLine("-------------\n1 25cL  [1€]\n2 33cL  [2€]\n-------------");
            int choice_volume;
            while (!int.TryParse(Console.ReadLine(), out choice_volume) || choice_volume > 2 || choice_volume < 1) {
                Console.WriteLine("Enter a number [1 or 2]");
            }
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
        
        // GETTERS AND SETTERS
        public float Price {
            get { return price; }
            set { price = value; }
        }

        public drink_type drink_Type {
            get { return drink; }
            set { drink = value; }
        }
        
    }  
}