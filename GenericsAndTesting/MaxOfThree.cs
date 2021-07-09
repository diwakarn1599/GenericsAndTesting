using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndTesting
{
    public class MaxOfThree
    {
        //method for finding max number
        public string MaxOfThreeNumbers(string num1, string num2, string num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
