using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Calculator
    {
        public static int Scitaj(int a, int b)

        {
            int Vysledok = a + b;
            return Vysledok;
        }
        public static int Scitaj(int a, int b, int c)
        {
            return a + b + c;
        }
          
        public static int Scitaj(string a, string b)
        {
            int mv1 = int.Parse(a);
            int mv2 = int.Parse(b);

            int Vysledok = 10;
            switch (Vysledok)
            {
                case 2:
                    Console.WriteLine("Vysledok bol 2");
                    break;


                    if (Vysledok >= 10 && Vysledok <= 20 || Vysledok >= 40 && Vysledok <= 60)

                    {
                    }
            }
        }
        
        
    }
}
