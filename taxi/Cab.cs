using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class Cab
    {
        public Cab(int id, string car, District district)
        {
            Id = id;
            Car = car;
            CurrentDistrict = district;
            IsAvailable = true;
        }
        public int Id { get; set; }
        public string Car { get; set; }
        public bool IsAvailable { get; set; }
        public string Status
        {
            get { return IsAvailable ? "wolna" : "zajęta"; }
        }
        public District CurrentDistrict { get; set; }
        public int ArrivalTime { get; set; }

        public void CalculateArrivalTime(District customerDistrict)
        {
            if (IsAvailable)
            {
                if (customerDistrict.Number == CurrentDistrict.Number)
                    ArrivalTime = 4;
                else
                {
                    var route = Math.Abs(customerDistrict.Distance - CurrentDistrict.Distance);
                    ArrivalTime = route * 5;
                }
                if (!IsAvailable)
                    ArrivalTime += 12;
            }
        }
    }
}
