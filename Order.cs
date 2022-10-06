using System;

namespace ProjetApplication
{
    class Order
    {
        private int orderID = 0;
        private DateTime hours;
        // private Client client = new Client();
        private Help_cooker help_cooker = new Help_cooker();
        private Boolean state = false;
        private Pizza[] pizzas = new Pizza[10];
        private Drink[] drinks = new Drink[10];
    }

}