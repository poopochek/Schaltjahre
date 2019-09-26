using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schaltjahre
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jahr;
            Console.WriteLine("Schaltjahre sollen bestimmt werden.");
            Console.WriteLine("Geben Sie ein Jahr ein:");
            Jahr = Convert.ToInt32(Console.ReadLine());

            // and ist &&; or ist ||
            if(Jahr % 4 == 0 && (Jahr % 100 != 0 || Jahr % 400 == 0))
            {


                Console.WriteLine("Das Jahr "+  Jahr  +" ist ein Schaltjahr.");
                // Console.WriteLine("Das Jahr {0} ist ein Schaltjahr.", Jahr);
            }
            else
            {
                Console.WriteLine("Das Jahr " + Jahr + " ist kein Schaltjahr.");

            }
        }
    }
}
