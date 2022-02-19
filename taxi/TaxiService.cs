using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class TaxiService
    {
        public TaxiService()
        {
            CreateDistricts();
            CreateCabs();
        }
        public List<District> Districts { get; set; } = new List<District>();
        public List<Cab> Cabs { get; set; } = new List<Cab>();
        public List<District> CustomerDistrict { get; set; } = new List<District>();
        private void CreateDistricts()
        {
            Districts.Add(new District(1, "Retkinia", -2));
            Districts.Add(new District(2, "Łódź Kaliska", -1));
            Districts.Add(new District(3, "Śródmieście", 0));
            Districts.Add(new District(4, "Widzew", 1));
            Districts.Add(new District(5, "Janów", 3));
        }
        private void CreateCabs()
        {
            Cabs.Add(new Cab(1, "Ford Mondeo",  Districts[0]));
            Cabs.Add(new Cab(2, "Dacia Logan",  Districts[1]));
            Cabs.Add(new Cab(3, "Toyota Avensis", Districts[2]));
            Cabs.Add(new Cab(4, "Mercedes E220	", Districts[3]));
            Cabs.Add(new Cab(5, "Huindai Lantra", Districts[4]));
        }
        public void Menu()
        {
            Console.WriteLine("Wybierz opcję: ");
            Console.WriteLine("1 =>Lista wszystkich dzielnic i taksówek");
            Console.WriteLine("2 =>ZAMÓW TAKSÓWKĘ");
            Console.WriteLine("3 =>ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1,2 LUB 3 ");
            string key=Console.ReadLine();
            if (key == "1") { ShowAllDistrictAndTaxi(); }
            else if (key == "2") { Order(); }
            else if (key == "3") { return ; }
            else
            {
                Console.Clear();
                Menu();
            }
        }
        static bool IsItaGoodDistrict(string Ordervalue)
        {
            return Ordervalue == "1" || Ordervalue == "2" || Ordervalue == "3" || Ordervalue == "4"|| Ordervalue == "5";
        }
        public void ShowAllDistrictAndTaxi()
        {

            Console.Clear();
            Console.WriteLine("Lista DZIELNIC");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
            foreach (District item in Districts)
            {

                int CabsInDistrict = 0;
                foreach (Cab Car in Cabs)
                {
                    if (Car.CurrentDistrict.Name == item.Name)
                        CabsInDistrict++;
                }

                Console.WriteLine($"{item.Number} | {item.Name} | {CabsInDistrict}");
            }
            Console.WriteLine("SAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA");
            foreach (Cab item in Cabs)
            {
                Console.WriteLine($"{item.Car} | {item.Status} | {item.CurrentDistrict.Name}");
            }
            Menu();
        }
        public  void Order()
        {
            Console.WriteLine("PROSZĘ PODAĆ NUMER DZIELNICY DO KTÓREJ CHCESZ WEZWAĆ TAKSÓWKĘ:");
            string districtvalue = Console.ReadLine();
            bool goodkey = IsItaGoodDistrict(districtvalue);
            while(!goodkey)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NIEPRAWIDŁOWY NUMER DZIELNICY");
                Console.ForegroundColor = ConsoleColor.White;
                Order();
            }
            int OrderValue = int.Parse(districtvalue);
 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"ZLECENIE REALIZUJE: { }");
            //  Console.WriteLine($"CZAS DOJAZDU: { }");
            Cab.CalculateArrivalTime(Districts[OrderValue]);
            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Lista DZIELNIC");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
                foreach (District item in Districts)
                { 
                    int CabsInDistrict = 0;
                    foreach (Cab Car in Cabs)
                    {
                        if (Car.CurrentDistrict.Name == item.Name ){CabsInDistrict++;}
                        
                    }
                    Console.WriteLine($"{item.Number} | {item.Name} | {CabsInDistrict}");

            }
                foreach (Cab item in Cabs)
                {
                    Console.WriteLine($"{item.Car} | {item.Status} | {item.CurrentDistrict.Name} | {item.ArrivalTime}");
                }
            }
        }
    }
