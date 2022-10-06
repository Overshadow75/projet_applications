using System;

namespace ProjetApplication
{
    class Client : Person
    {
        private string phone = "";
        private DateTime first_order;

        // constructor
        public Client(int personID, string name, string surname, int metierID,string phone, DateTime first_order) :base(personID, name, surname, metierID){ 
            this.phone = phone;
            this.first_order = first_order;
        }
        
        public string Phone {
            get => phone;
            set => phone = value;
        }

    }
}