using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
            {
        public int globalnaPremenna = 7;
        void TestGlobalnejPremennej()
        {
            int lokalnaPremenna = 9;
            globalnaPremenna++;
        }
        static void Main(string[] args)
        {
            const int mojaKonstanta = 4;
            int polomer = 6;
            //polomer = polomer + 1;
            polomer+=6 ;
            Console.WriteLine("Povodny polomer {0}", polomer);

            int novyPolomer = polomer++;
            Console.WriteLine("Novy polomer {0}", novyPolomer);

            int zaseNovyPolomer = ++polomer;
            Console.WriteLine("Zase Novy polomer {0}", zaseNovyPolomer);

            Calculator.Scitaj(5, 2);
            Console.ReadLine();
        }
    }
    }

