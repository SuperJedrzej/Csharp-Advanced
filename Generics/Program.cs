using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(9);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueDefault());
            Console.ReadKey();
         }
    }
}
