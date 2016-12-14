﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CAExamples.Models
{
    public enum Operator
    {
        [Display(Name = "+")]
        ADD,
        [Display(Name = "-")]
        SUBTRACT
    }
    public class Calculator
    {
        public double Input1 { get; set; }
        public double Input2 { get; set; }
        public Operator Operator { get; set; }

        public double Calculate
        {
            get
            {
                if(Operator == Operator.ADD)
                {
                    return Input1 + Input2;
                }
                else
                {
                    return Input1 - Input2;
                }
            }
        }
    }
}