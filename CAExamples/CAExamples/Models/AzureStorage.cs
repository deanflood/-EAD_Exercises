using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CAExamples.Models
{
    public enum InstanceSize
    {
        [Display(Name = "Small")]
        SMALL,

        [Display(Name = "Medium")]
        MEDIUM,

        [Display(Name = "Large")]
        LARGE
    }
    public class AzureStorage
    {
        [Range( 2, Int32.MaxValue, ErrorMessage = "Must be at least 2")]
        [Display(Name = "Select Instance Number")]
        public int NumberInstance { get; set; }

        [Display(Name = "Select Instance Size")]
        public InstanceSize InstanceSize { get; set; }

        public double getCost
        {
            get
            {
                return calculateYearlyCost();
            }
        }

        private double calculateYearlyCost()
        {
            int billableHours = 24 * 365;
            double hourlyCost = 0.00;
            if (DateTime.IsLeapYear(DateTime.Now.Year)){
                billableHours = 24 * 366;
            }

            if (InstanceSize == InstanceSize.SMALL)
            {
                hourlyCost = 0.08;
            }
            else if (InstanceSize == InstanceSize.MEDIUM)
            {
                hourlyCost = 0.16;
            }
            else
            {
                hourlyCost = 0.32;
            }

            return hourlyCost * billableHours;
        }
    }
}