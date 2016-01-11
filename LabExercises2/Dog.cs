using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises2
{
    public class Dog : Animal
    {
        public enum Breed { Bulldog, Lab, Boxer, Retriever};
        public Breed breed;
        public Dog(string name, int age, Breed _breed)
        {
            Name = name;
            Age = age;
            breed = _breed;
        }

        public void PrintDog()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Breed: {0}", breed);
        }
    }
}
