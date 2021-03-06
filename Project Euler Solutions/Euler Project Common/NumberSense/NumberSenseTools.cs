﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCommon.NumberSense
{
    public static class NumberSenseTools
    {
        public static bool IsAPrime(double testValue)
        {
            if (testValue == 1) return false;
            if (testValue == 2) return true;

            double testBoundry = Math.Floor(Math.Sqrt(testValue));//https://en.wikipedia.org/wiki/Prime_number#Trial_division

            for (int i = 2; i <= testBoundry; i++)
            {
                if(testValue % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void CollatzSequence(long startingNumber, List<long> sequence)
        {
            sequence.Add(startingNumber);

            if(startingNumber == 1)
            {
                sequence.Add(1);
                return;
            }

            if(startingNumber % 2 == 0)
            {
                CollatzSequence(startingNumber / 2, sequence);
            }
            else
            {
                CollatzSequence(3 * startingNumber + 1, sequence);
            }
        }
    }
}
