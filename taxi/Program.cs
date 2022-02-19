using System;
using System.Collections.Generic;
using taxi;

namespace taxi
{

}
class Program
   
{
        static void Main(string[] args)
        {
        static void ShowAllDistrictAndTaxi()
        {
            TaxiSerivice();
            Console.Clear();
            Console.WriteLine("Lista DZIELNIC");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
            /*foreach (var Districts in District)
            {
            
            }*/
            Console.WriteLine("SAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA");
            foreach (Cab item in TaxiService.Cabs)
            {
                Console.WriteLine($".{ item.car}. .{item.Status}. .{item.CurrentDistrict}");
            }
            Menu();
        }
        static bool IfGoodKey(string key)
        {
            return key == "1" || key == "2" || key == "3";
        }
        static void Menu()
        {
            Console.WriteLine("Wybierz opcję: ");
            Console.WriteLine("1 =>Lista wszystkich dzielnic i taksówek");
            Console.WriteLine("2 =>ZAMÓW TAKSÓWKĘ");
            Console.WriteLine("3 =>ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1,2 LUB 3 ");
            string key=Console.ReadLine();
            bool goodkey = IfGoodKey(key);
            if (key == "1")
            {
                ShowAllDistrictAndTaxi();
            }
            else if (key == "2") { Console.WriteLine(2); }
            else if (key == "3") {  }
            else { Menu(); }
        }

        Menu();
     
    }
}
