using System;
#pragma warning disable 8600, 8601
namespace ProjetApplication
{
    class Client : Person
    {
        private string phone = "";
        private DateTime first_order;

        //Address
        private int number = 0;
        private string streetName = "";
        private string city = "";
        private string zipCode = "";
        private string country = "";

        // constructor
        public Client(int personID, string name, string surname, int metierID,string phone, DateTime first_order, int number, string streetName, string city, string zipCode, string country) :base(personID, name, surname, metierID){ 
            this.phone = phone;
            this.first_order = first_order;
            this.number = number;
            this.streetName = streetName;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }
        
        public string Phone {
            get => phone;
            set => phone = value;
        }

        // getter address
        public string Address {
            get => number + " " + streetName + " " + city + " " + zipCode + " " + country;
        }
        public void enterClient() {
            Console.WriteLine("Enter the client's informations");

            Console.WriteLine("Person ID : ");
            //random personID
            Random random = new Random();
            int personID = random.Next(1, 1000);

            Console.WriteLine("Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Surname : ");
            string surname = Console.ReadLine();

            Console.WriteLine("1 for employee, 2 for client ");
            Console.WriteLine("Metier ID : ");
            int metierID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Phone : ");
            string phone = Console.ReadLine();

            // Console.WriteLine("First order : ");
            DateTime first_order = DateTime.Now;

            Console.WriteLine("Enter address's informations: ");
            Console.WriteLine("Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Street name : ");
            string streetName = Console.ReadLine();

            Console.WriteLine("City : ");
            string city = Console.ReadLine();

            Console.WriteLine("Zip code : ");
            string zipCode = Console.ReadLine();

            Console.WriteLine("Country : ");
            string country = Console.ReadLine();

            Client c = new Client(personID, name, surname, metierID, phone, first_order, number, streetName, city, zipCode, country);
            Pizzeria pizzeria = new Pizzeria();
            pizzeria.addClient(c);
        }

        public void enterAddress() { // in case of modification of the adress
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

        public void printClient(){
            Console.WriteLine("CLIENT" + "\n" + "Person ID : " + this.personID + "\n" + "Name : " + this.name + "\n" + "Surname : " + this.surname + "\n" + "Metier ID : " + this.metierID + "\n" + "Phone : " + this.phone + "\n" + "First order : " + this.first_order);
        }

        // Print the address of a client
        public void printAddress(){
            Console.WriteLine("Address : " + this.number + " " + this.streetName + " " + this.city + " " + this.zipCode + " " + this.country);
        }

    }    
}