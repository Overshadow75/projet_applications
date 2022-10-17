using System;
// #pragma warning disable 8618
// #pragma warning disable 8625
namespace ProjetApplication
{
    class Pizzeria 
    {
        private string companyName = "O'pizza";

        // list Client
        private List<Client> client_list = new List<Client>(); //TODO: Passer en private

        // list of order
        private List<Order> order_list = new List<Order>(); //passer en Private

        // Unique Help_Cooker nullable
        private Help_cooker help_cooker = null;
        public Help_cooker Help_cooker {
            get { return help_cooker; }
            set { help_cooker = value; }
        }

        // Chef
        private Chef chef = null;
        // setter chef
        public Chef Chef {
            get { return chef; }
            set { chef = value; }
        }
        
        private Delivery_man delivery = null;
        public Delivery_man Delivery_Man {
            get {return delivery;}
            set { delivery = value;}
        }
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

    
