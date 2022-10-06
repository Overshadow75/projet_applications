using System;

namespace ProjetApplication
{
    class Address
    {
        private int number = 0;
        private string streetName = "";
        private string city = "";
        private string zipCode = "";
        private string country = "";

        // print address
        public void printAddress(){
            Console.WriteLine("Address : " + this.number + " " + this.streetName + " " + this.city + " " + this.zipCode + " " + this.country);
        }
    }
}