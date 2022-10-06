using System;

namespace ProjetApplication
{
    class Drink
    {
        private drink_type drink;
        private float volume;
        private float price;
        
        public void enterDrink() {
        Console.WriteLine("Enter the drink's informations");

        Console.WriteLine("Name : ");
        this.drink = drink_type.coca;

        Console.WriteLine("Volume : ");
        this.volume = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Price : ");
        this.price = Convert.ToSingle(Console.ReadLine());
        }
    }  
}