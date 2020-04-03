using System;

namespace AB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++){ Console.WriteLine(i);};
            /* Zaehlt
             * 1
             * 2
             * 3
             */ 
            for (int i = 1; i <= 3; Console.WriteLine(++i)) {};*/
            /* Zaehlt
             * 2
             * 3
             * 4
             */
             for (int i = 1; ; Console.WriteLine(i++)) { };
            /* Zaehlt von 1 bis infinity /*
             
            /* Der letzte ist unerreichbar 
             * for (; ; ) { };
             */
        }
    }
}
