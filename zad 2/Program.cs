﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
           {
            Console.WriteLine("a =");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("Square =" );
            Console.WriteLine(area);
        }
    }
}
