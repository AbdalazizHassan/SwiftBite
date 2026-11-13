using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftBite.Business.Common
{
    public sealed class CompanyPolicy
    {
        private static readonly Lazy<CompanyPolicy> _instance = new(() => new CompanyPolicy());
        public static CompanyPolicy Instance => _instance.Value;

        private CompanyPolicy()
        {

        }

        // Pricing
        public decimal VatRate { get; set; } = 0.14m;                          // BR-21
        public decimal StandardBaseFee { get; set; } = 15m;                    // BR-18
        public double StandardBaseKm { get; set; } = 3;
        public decimal FeePerExtraKm { get; set; } = 4m;
        public decimal PeakMultiplier { get; set; } = 1.3m;                    // BR-19
        public TimeSpan PeakStart { get; set; } = new(19, 0, 0);
        public TimeSpan PeakEnd { get; set; } = new(22, 0, 0);
        public decimal PremiumFreeDeliveryMinSubtotal { get; set; } = 150m;    // BR-20

        // Limits
        public int MaxAddresses { get; set; } = 3;                             // BR-03
        public decimal MinTopUp { get; set; } = 10m;                           // BR-04
        public decimal MaxTopUp { get; set; } = 5000m;
        public int MinDriverAge { get; set; } = 18;                            // BR-05
        public double BicycleMaxKm { get; set; } = 3;                          // BR-07
        public double MotorcycleMaxKm { get; set; } = 7;
        public decimal MaxItemPrice { get; set; } = 2000m;                     // BR-09
        public double MaxDeliveryRadiusKm { get; set; } = 7;                   // BR-10
        public int MaxQuantity { get; set; } = 10;                             // BR-12
        public decimal MinOrderSubtotal { get; set; } = 50m;                   // BR-15
        public int MaxActiveOrders { get; set; } = 2;                          // BR-16
        public decimal MaxCashOnDeliveryTotal { get; set; } = 1000m;           // BR-22

        public bool IsPeakHour(DateTime time) => time.TimeOfDay >= PeakStart && time.TimeOfDay < PeakEnd;



    }
}
