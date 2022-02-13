using System;

namespace taxi
{

}
class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Wybierz opcję: ");
            Console.WriteLine("1 =>Lista wszystkich dzielnic i taksówek");
            Console.WriteLine("2 =>ZAMÓW TAKSÓWKĘ");
            Console.WriteLine("3 =>ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1,2 LUB 3 ");
            Console.ReadLine();

        static bool CzyDobryKlawisz(string klawisz)
        {
            return klawisz == "1" || klawisz == "2" || klawisz == "3" ;
        }
    }
}
