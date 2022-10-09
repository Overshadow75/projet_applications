using System;

namespace ProjetApplication
{
    abstract class  Person
    {
        protected int personID = 0;
        protected string name;
        protected string surname;
        protected int metierID = 0;

        // constructor
        public Person(int personID, string name, string surname, int metierID) {
            this.personID = personID;
            this.name = name;
            this.surname = surname;
            this.metierID = metierID;
        }
        
        public string Name {
            get => name;
            set => name = value;
        }
    }
}
