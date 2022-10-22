using System;
#pragma warning disable 8618
#pragma warning disable 8625
#pragma warning disable 8603
namespace ProjetApplication
{
    class Pizzeria 
    {
        // ATTRIBUTES
        private string companyName = "O'pizza";
        private float treasury = 0;
        
        private List<Client> client_list = new List<Client>();
        private List<Order> order_list = new List<Order>(); 
        
        /*In this file we implement help_cooker , chef, and delivery_man here to simplify their call in program.cs*/
        // Help_cooker
        private Help_cooker help_cooker = null;
        public Help_cooker Help_cooker {
            get { return help_cooker; }
            set { help_cooker = value; }
        }

        // Chef
        private Chef chef = null;
        public Chef Chef {
            get { return chef; }
            set { chef = value; }
        }
        
        // Delivery man
        private Delivery_man delivery = null;
        public Delivery_man Delivery_Man {
            get {return delivery;}
            set { delivery = value;}
        }

        // GETTERS AND SETTERS     
        public string CompanyName {
            get => companyName;
            set => companyName = value;
        }

        public List<Order> Order_list {
            get { return order_list; }
            set { order_list = value; }
        }

        public void addClient(Client c) {
            this.client_list.Add(c);
        }

        public float Treasury {
            get => treasury;
            set => treasury = value;
        }
        
        //FUNCTIONS
        // Function that check if the client is in the list
        public bool isClientInList(string phone) {
            foreach(Client c in this.client_list) {
                if(c.Phone == phone) {
                    Console.WriteLine("find " + c.Name + c.Surname);
                    return true;
                }
            }
            return false;
        }

        // Function that return the client if he is in the list
        public Client getClient(string phone) {
            foreach(Client c in this.client_list) {
                if(c.Phone == phone) {
                    return c;
                }
            }
            return null;
        }

        // Function that print the client list
        public void printClientList() {
            foreach(Client c in client_list) {
                c.printClient();
                
            }
        }

        // Function that add Order to the list of order
        public void addOrder(Order o) {
            this.order_list.Add(o);
        }

        // Function that print list of order
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

        // Function that add money to the treasury
        public void addToTreasury(float price) {
            this.treasury += price;
        }

        // Function that print the treasury
        public void printTreasury() {
            Console.WriteLine("Treasury : " + treasury);
        }
        
    }
}

    
