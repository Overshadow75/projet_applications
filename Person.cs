using System;

namespace ProjetApplication
{
    abstract class  Person
    {
        // ATTRIBUTES
        protected int personID = 0;
        protected string name;
        protected string surname;
        protected int metierID = 0;
        
        // CONSTRUCTORS
        // Constructor1 Person
        public Person(int personID, string name, string surname, int metierID) {
            this.personID = personID;
            this.name = name;
            this.surname = surname;
            this.metierID = metierID;
        }
        
        // Constructor2 Person
        public Person(){}
        
        //GETTERS AND SETTERS
        public string Name {
            get => name;
            set => name = value;
        }
        public string Surname {
            get => surname;
            set => surname = value;
        }
        
        public int PersonID {
            get => personID;
            set => personID = value;
        }
    }
}
