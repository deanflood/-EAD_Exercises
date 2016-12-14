using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CA3Sample2.Models
{
    public class PropertyTaxservice
    {
        private double TaxRate = double.Parse(ConfigurationManager.AppSettings["TaxRate"]);
        private List<TaxBand> TaxBands = TaxBand.GetTaxBands;

        public int HousePrice { get; set; }
        public bool HasSwimmingPool { get; set; }
        public double CalculateTax
        {
            get
            {
                TaxBand band = TaxBands.Find(n => HousePrice > n.LowerBound && HousePrice < n.UpperBound);
                if (HasSwimmingPool)
                {
                    return (band.MidPoint * TaxRate) + 10000;
                }
                return band.MidPoint * TaxRate;

            }
        }
    }
}