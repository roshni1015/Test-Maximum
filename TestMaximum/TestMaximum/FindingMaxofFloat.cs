﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class FindingMaxofFloat
    {
        public double MaxValueFloat(double a, double b, double c)
        {

            double max;
            max = a;
            if (b.CompareTo(max) > 0)
                max = b;
            if (c.CompareTo(max) > 0)
                max = c;
            return max;


        }
    }
}
