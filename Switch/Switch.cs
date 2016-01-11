using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Switch
    {
        public void GetValue()
        {
            int a = 2;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Value of a is 1");
                    break;
                case 2:
                    Console.WriteLine("Value of a is 2");
                    break;
                case 3:
                    Console.WriteLine("Value of a is 3");
                    break;
                default:
                    Console.WriteLine("Value of a is " + a);
                    break;
            }
        }

        public void WatchMovie()
        {
            Console.WriteLine("Please choose a movie to watch \n");
            string movie = Console.ReadLine();

            switch (movie)
            {
                case "Toy Story":
                    Console.WriteLine("Enjoy " + movie);
                    break;
                case "Saving Private Ryan":
                    Console.WriteLine(movie + " is a great war film");
                    break;
                case "Star Wars: The Force Awakens":
                    Console.WriteLine("Enjoy the new " + movie + " film!");
                    break;
                default:
                    Console.WriteLine("Not a valid movie at the moment");
                    break;
            }
        }
    }
}
