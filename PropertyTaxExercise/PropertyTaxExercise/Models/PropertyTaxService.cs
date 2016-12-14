using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;


namespace PropertyTaxExercise.Models
{
    public class PropertyTaxService
    {
        [Display(Name = "Property Worth")]
        [Range(0, 500000)]
        public int HousePrice { get; set; }

        [Display(Name = "Tax Band")]
        public int TaxBandIndex { get; set; }

        [Display(Name = "Tax Due")]
        public double PropertyTax
        {
            get
            {
                double TAX_RATE = ApplicationSettings.TaxRate;
                List<TaxBand> taxBands = TaxBand.TaxBands;
                for(int i = 0; i < taxBands.Count; i++)
                {
                    if(HousePrice >= taxBands[i].LowerBound && HousePrice <= taxBands[i].UpperBound)
                    {
                        TaxBandIndex = i + 1;
                        return taxBands[i].Midpoint * Convert.ToDouble(TAX_RATE) ;
                    }
                }
                return 0;
            }
        }
    }  
}