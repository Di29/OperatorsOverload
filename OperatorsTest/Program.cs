using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Part firstPart = new Part { Name = "Nasos" };
            Part secondPart = new Part { Name = "Balon" };

            var complete = firstPart + secondPart;

            Console.WriteLine($"Название прибора {complete.Name}," + $"количество частей {complete.Parts.Length}");

            Console.ReadLine();
        }
    }
}
