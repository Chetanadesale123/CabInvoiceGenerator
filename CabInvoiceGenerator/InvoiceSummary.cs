using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public int totalNumberOfRides;
        public double totalFare;
        public double AvgFairPerRide;
        public InvoiceSummary(int totalNumberOfRides, double totalFare)
        {
            this.totalNumberOfRides = totalNumberOfRides;
            this.totalFare = totalFare;
            this.AvgFairPerRide = this.totalFare / this.totalNumberOfRides;
        }
    }
}
