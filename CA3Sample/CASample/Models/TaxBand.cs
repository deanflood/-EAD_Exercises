using System.Collections.Generic;

namespace CA3Sample2.Models
{
    public class TaxBand
    {
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }
        public int MidPoint { get; set; }

        public TaxBand(int lower, int upper, int mid)
        {
            LowerBound = lower;
            UpperBound = upper;
            MidPoint = mid;
        }

        public static List<TaxBand> GetTaxBands
        {
            get
            {
                return new List<TaxBand>()
                {
                     new TaxBand(0,      100000, 50000),
                     new TaxBand(100001, 150000, 125000),
                     new TaxBand(150001, 200000, 175000),
                     new TaxBand(200001, 250000, 225000),
                     new TaxBand(250001, 300000, 275000)
                };
            }
        }
    }
}