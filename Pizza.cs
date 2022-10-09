using System;

namespace ProjetApplication
{
    class Pizza
    {
        private pizza_size size;
        private pizza_type type;
        private float price;


        // Constructor
        public Pizza(int i) {

            Console.WriteLine("Which pizza do you want : " + i);
            Console.WriteLine("1 for margherita | 5$, 2 for tomate sauce | 7$, 3 for cheese sauce | 9$, 4 for vegetarian | 11$");
            int choice_type = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine("Which size : ");
            Console.WriteLine("1 for small | +1$, 2 for medium | +2$, 3 for large | +3$");
            int choice_size = Convert.ToInt32(Console.ReadLine());
            switch(choice_size) {
                case 1:
                    this.size = pizza_size.small;
                    this.price = 5 + 1;
                    break;
                case 2:
                    this.size = pizza_size.medium;
                    this.price = 7 + 2;
                    break;
                case 3:
                    this.size = pizza_size.large;
                    this.price = 9 + 3;
                    break;
            }


        }


        // getter on every attributes
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


    }
}