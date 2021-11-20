using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          while (true)
            {
                Console.WriteLine("Hauptmenue: ");
                Console.WriteLine("############");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraktion");
                Console.WriteLine("3) Schliesse das Programm");
                Console.WriteLine("#############");
                Console.WriteLine("Deine eingabe:");



                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        return;
                    default:
                        break;
                }


            }  
        }

        static int Addition(int x, int y)
        {
            return x + y;
               
        
        }
        /// <summary>
        /// kommentar
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int Subtraktion(int x, int y) { return x - y; }
    }
}
