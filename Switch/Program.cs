﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch _switch = new Switch();
            _switch.GetValue();

            _switch.WatchMovie();
            Console.ReadLine();
        }
    }
}
