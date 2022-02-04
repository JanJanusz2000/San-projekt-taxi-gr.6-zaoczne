using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class TaxiSerivice()
    {
        CreateDistricts();
    CreateCabs();
}
public List<District> Districts { get; set; } = new List<District>();
public List<Cab> Cabs { get; set; } = new List<Cab>();
private void CreateCabs()
{
    Cabs.Add(new Cab(1, "Ford Mondeo", District[0]);
    Cabs.Add(new Cab(2, "Dacia Logan", District[1]);
    Cabs.Add(new Cab(3, "Toyota Avensis", District[2]);
    Cabs.Add(new Cab(4, "Mercedes E220	", District[3]);
    Cabs.Add(new Cab(5, "Huindai Lantra", District[4]);
}
private void CreateDistricts
{
    Districts.Add(new District(1, "Retkinia", -2));
Districts.Add(new District(2, "Łódź Kaliska", -1));
Districts.Add(new District(3 "Śródmieście", 0));
Districts.Add(new District(4, "Widzew", 1));
Districts.Add(new District(5, "Janów", 3));
}
}
