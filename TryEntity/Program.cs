﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService.Load();
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();
        }
    }
}
