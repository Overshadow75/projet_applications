using System;

namespace ProjetApplication
{
    class Address
    {
        // ATTRIBUTES
        private int number = 0;
        private string streetName = "";
        private string city = "";
        private string zipCode = "";
        private string country = "";

        //FUNCTIONS
        // Function to print the address
        public void printAddress(){
            Console.WriteLine("Address : " + this.number + " " + this.streetName + " " + this.city + " " + this.zipCode + " " + this.country);
        }
        
    }
}