using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyTaxExercise.Models
{
    public class TaxBand
    {
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }
        public int Midpoint { get; set; }

        public TaxBand(int lower, int upper, int mid)
        {
            LowerBound = lower;
            UpperBound = upper;
            Midpoint = mid;
        }

        public static List<TaxBand> TaxBands
        {
            get
            {
                return new List<TaxBand>()
                {
                    { new TaxBand(0,      100000,  50000) },
                    { new TaxBand(100001, 150000, 125000) },
                    { new TaxBand(150001, 200000, 175000) },
                    { new TaxBand(200001, 250000, 225000) },
                    { new TaxBand(250001, 300000, 275000) },
                    { new TaxBand(300001, 350000, 325000) },
                    { new TaxBand(350001, 400000, 375000) },
                    { new TaxBand(400001, 450000, 425000) },
                    { new TaxBand(450001, 500000, 475000) }
                };
            }
        }
    }
}