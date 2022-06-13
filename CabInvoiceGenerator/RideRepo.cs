using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepo
    {
        Dictionary<string, Ride[]> rideDict = new Dictionary<string, Ride[]>();
        public void Addrides(string userId, Ride[] rides)
        {
            if (!rideDict.ContainsKey(userId))
            {
                rideDict.Add(userId, rides);
            }
        }
        public Ride[] GetRides(string userId)
        {
            foreach (var data in rideDict)
            {
                if (data.Key == userId)
                {
                    return data.Value;
                }
            }
            return null;
        }
    }
}
