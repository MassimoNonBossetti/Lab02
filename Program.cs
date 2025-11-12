using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace espressioniregolari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inerisci un testo");
            string input=Console.ReadLine();
            Console.WriteLine("inserisci una espressione regolare");
            string espressione=Console.ReadLine();
            EsprReg e=new EsprReg(input ,  espressione);
           
            if(e.testEspr())
            {
                Console.WriteLine("contiene la espressione regolare");

            }
            else
            {
                Console.WriteLine("non contiene la espressione regolare");
            }
            Console.ReadKey();
        }
    }
}

