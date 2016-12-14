using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PropertyTaxExercise.Models
{
    public static class ApplicationSettings
    {
        public static double TaxRate
        {
            get { return double.Parse(ConfigurationManager.AppSettings["TaxRate"]); }
        }
    }
}