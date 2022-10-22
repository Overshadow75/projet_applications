using System;

namespace ProjetApplication
{
    class Pizza
    {
        // ATTRIBUTES
        private pizza_size size;
        private pizza_type type;
        private float price;


        // CONSTRUCTORS
        public Pizza(int i) {

            // Choice of the pizza_type
            Console.WriteLine("Which pizza do you want : ");
            Console.WriteLine("--------------------\n1 margherita  [5€]\n2 tomato      [7€]\n3 cheese      [9€]\n4 vegetarian  [11€]\n--------------------");
            int choice_type;
            while (!int.TryParse(Console.ReadLine(), out choice_type) || choice_type > 4 || choice_type < 1) {
                Console.WriteLine("Enter a number [1, 2, 3 or 4]");
            }
            switch(choice_type) {
                case 1:
                    this.type = pizza_type.margherita;
                    this.price = 5;
                    break;
                case 2:
                    this.type = pizza_type.tomato_sauce;
                    this.price = 7;
                    break;
                case 3:
                    this.type = pizza_type.cheese_sauce;
                    this.price = 9;
                    break;
                case 4:
                    this.type = pizza_type.vegan;
                    this.price = 11;
                    break;
            }

            // Choice of the pizza_size
            Console.WriteLine("Which size : ");
            Console.WriteLine("-------------\n1 Small  [1€]\n2 Medium [2€]\n3 Large  [3€]\n-------------");
            int choice_size;
            while (!int.TryParse(Console.ReadLine(), out choice_size) || choice_size > 3 || choice_size < 1) {
                Console.WriteLine("Enter a number [1, 2 or 3]");
            }
            switch(choice_size) {
                case 1:
                    this.size = pizza_size.small;
                    this.price = price + 1;
                    break;
                case 2:
                    this.size = pizza_size.medium;
                    this.price = price + 2;
                    break;
                case 3:
                    this.size = pizza_size.large;
                    this.price = price + 3;
                    break;
            }
        }

        // GETTERS AND SETTERS
        public pizza_size pizza_Size {
            get => size;
            set => size = value;
        }

        public pizza_type pizza_Type {
            get => type;
            set => type = value;
        }

        public float Price {
            get => price;
            set => price = value;
        }

        //FUNCTIONS
        // Function that display that the pizza is being prepared
        public void preparePizza() {
            Console.WriteLine("Preparing the pizza " + this.pizza_Type);
        }

    }
}