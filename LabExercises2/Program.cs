using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog Lambeu = new Dog("Lambeau", 4, Dog.Breed.Lab);
            Lambeu.PrintDog();
        }
    }
}
