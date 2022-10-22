using System;
#pragma warning disable 8600, 8601
namespace ProjetApplication
{
    class Client : Person
    {
        // ATTRIBUTES
        private string phone = "";
        private DateTime first_order;

        //Address
        private int number = 0;
        private string streetName = "";
        private string city = "";
        private string zipCode = "";
        private string country = "";

        public static int countPersonID = 0;
        
        // CONSTRUCTORS
        // Constructor1 Client
        public Client(int personID, string name, string surname, int metierID,string phone, DateTime first_order, int number, string streetName, string city, string zipCode, string country) :base(personID, name, surname, metierID){ 
            this.phone = phone;
            this.first_order = first_order;
            this.number = number;
            this.streetName = streetName;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }

        // Constructor2 Client
         public Client() {
            this.personID = countPersonID++;
            Console.WriteLine("Person ID : " + personID);

            Console.WriteLine("Name : ");
            string name = Console.ReadLine();
            this.name = name;

            Console.WriteLine("Surname : ");
            string surname = Console.ReadLine();
            this.surname = surname;

            //1 for employee, 2 for client 
            this.metierID = 2;

            Console.WriteLine("Phone : ");
            string phone = Console.ReadLine();
            this.phone = phone;

            DateTime first_order = DateTime.Now;

            Console.WriteLine("Enter address's informations: ");
            Console.WriteLine("Number : ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number)) 
            {
                Console.WriteLine("Please enter a number");
            }
            this.number = number;

            Console.WriteLine("Street name : ");
            string streetName = Console.ReadLine();
            this.streetName = streetName;

            Console.WriteLine("City : ");
            string city = Console.ReadLine();
            this.city = city;

            Console.WriteLine("Zip code : ");
            string zipCode = Console.ReadLine();
            this.zipCode = zipCode;

            Console.WriteLine("Country : ");
            string country = Console.ReadLine();
            this.country = country;
        }

        // GETTERS AND SETTERS
        public string Phone {
            get => phone;
            set => phone = value;
        }

        public string Address {
            get => number + " " + streetName + " " + city + " " + zipCode + " " + country;
        }

        public DateTime First_order {
            get => first_order;
        }
       
       // Global getter for all the informations
        public string AllInfo {
            get => "Name : " + name + " Surname : " + surname + " Phone : " + phone + " First order : " + first_order + " Address : " + number + " " + streetName + " " + city + " " + zipCode + " " + country;
        }

        //FUNCTIONS
        // Function to print the client
        public void printClient(){
            Console.WriteLine("CLIENT" + "\n" + "Person ID : " + this.personID + "\n" + "Name : " + this.name + "\n" + "Surname : " + this.surname + "\n" + "Metier ID : " + this.metierID + "\n" + "Phone : " + this.phone + "\n" + "First order : " + this.first_order);
        }

        // Function to print the address of a client
        public void printAddress(){
            Console.WriteLine("Address : " + this.number + " " + this.streetName + " " + this.city + " " + this.zipCode + " " + this.country);
        }

        // Function to edit the address
        public void editAddress() {
            Console.WriteLine("Enter your address");
            Console.WriteLine("Street : ");
            this.streetName = Console.ReadLine();

            Console.WriteLine("City : ");
            this.city = Console.ReadLine();

            Console.WriteLine("Zip code : ");
            this.zipCode = Console.ReadLine();
            
            Console.WriteLine("Country : ");
            this.country = Console.ReadLine();
        }
        
    }    
}