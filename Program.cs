using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo sa klasom String";

            //Broj znakova
            Console.WriteLine("Broj znakova u rečenici: {0}", recenica.Length);

            //ispis malim i velikim slovima
            Console.WriteLine("\n ------  Tolower is Toupper");
            Console.WriteLine(recenica.ToLower());
            Console.WriteLine(recenica.ToUpper());

            //metoda substring
            Console.WriteLine("\n -----substring");
            Console.WriteLine(recenica.Substring(6));
            Console.WriteLine(recenica.Substring(0,5));

            //Metoda replace
            Console.WriteLine("\n ------ replace");
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));

            //Metoda split
            Console.WriteLine("\n ----Split");
            string[] rijeci = recenica.Split(' ' );
            for(int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }

            //Metoda indey of i insert
            Console.WriteLine("\n ----indexof i insert");
            int pozicija = recenica.IndexOf("radimo");
            if(pozicija >= 0)
            {
                Console.WriteLine(recenica.Insert(pozicija, "intenzivno "));
            }

            Console.ReadKey();
        }
    }
}
