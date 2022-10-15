using System;

namespace ProjetApplication
{
    class Pizzeria 
    {
        private string companyName = "O'pizza";

        // list Client
        public List<Client> client_list = new List<Client>();

        // list of order
        public List<Order> order_list = new List<Order>();
        
        //constructor
        
        public string CompanyName {
            get => companyName;
            set => companyName = value;
        }

        // getter list_order
        public List<Order> Order_list {
            get { return order_list; }
            set { order_list = value; }
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

        // tostring client_list
        public void printClientList() {
            foreach(Client c in client_list) {
                c.printClient();
                
            }
        }

        // add order to the list of order
        public void addOrder(Order o) {
            this.order_list.Add(o);
        }

        // print order list
        public void printOrderList() {
            if (order_list.Count == 0) {
                Console.WriteLine("No order (fichier pizzeria)");
            }
            else {
                foreach(Order o in order_list) {
                    Console.WriteLine(o);
                }
            }
        }

        public Order returnOrder(){
            return order_list[order_list.Count-1];
           //return this.order_list[0];
        }
    }
}

    
