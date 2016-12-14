using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CAExamples.Models
{
    public enum RedundancyType
    {
        [Display(Name = "Geograpic")]
        GEOGRAPICALLY,

        [Display(Name = "Local")]
        LOCALLY
    }
    public class AzureRedundency
    {
        public int Size { get; set; }
        public RedundancyType Redundancy { get; set; }

        public double getCost
        {
            get
            {
                if(Redundancy == RedundancyType.GEOGRAPICALLY)
                {
                    if(Size <= 1000)
                    {
                        return Size * 0.125;
                    }
                    else
                    {
                        return 1000 * 0.125 + (Size - 1000) * 0.11;
                    }
                }
                else
                {
                    if (Size <= 1000)
                    {
                        return Size * 0.093;
                    }
                    else
                    {
                        return 1000 * 0.093 + (Size - 1000) * 0.083;
                    }
                }
            }
        }
    }
}