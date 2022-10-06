using System;

namespace ProjetApplication
{
    class Pizzeria 
    {
        private string companyName = "O'pizza";
        private int nbEmployees = 0;
        // list Client
        public List<Client> client_list = new List<Client>();
        
        //constructor
        
        public string CompanyName {
            get => companyName;
            set => companyName = value;
        }

        public void addClient(Client c) {
            this.client_list.Add(c);
        }
        // verifier si le phone client est dans la liste des clients
        public bool isClientInList(string phone) {
            foreach(Client c in this.client_list) {
                if(c.Phone == phone) {
                    Console.WriteLine("find " + c.Name);
                    return true;
                }
            }
            return false;
        }

        public int countEmployees()
        {
            return nbEmployees;
        }

        // tostring client_list
        public void printClientList() {
            foreach(Client c in client_list) {
                c.printClient();
                
            }
        }
    }
}

    
