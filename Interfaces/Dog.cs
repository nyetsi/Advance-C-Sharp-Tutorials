using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Dog:IAnimal,IComparable
    {

        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Nino"));
            dogs.Add(new Dog("Adam"));
            dogs.Add(new Dog("Bob"));
            dogs.Sort();
            foreach (var dog in dogs)
                Console.WriteLine(dog.Describe());
            Console.ReadLine();
        }

        public string name { get; set; }

        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        public Dog(string name)
        {
            this.Name = name;
        }

        public string Describe()
        {
            return "Hi i am a dog and my name is: " + this.Name;
        }

        public int CompareTo(object obj)
        {
            if(obj is IAnimal)
                return this.Name.CompareTo((obj as IAnimal).Name);
            return 0;
        }
    }
}
