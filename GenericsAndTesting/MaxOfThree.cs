using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndTesting
{
    public class MaxOfThree<T> where T : IComparable
    {
        public T num1, num2, num3;
        public T[] array;

        public MaxOfThree(T[] arr)
        {
            array = arr;
        }
        public MaxOfThree(T n1,T n2,T n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
        }
        //method for finding max number
        public T MaxOfThreeNumbers()
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

        public T FindMaxOfArray()
        {
            Array.Sort(this.array);
            Console.WriteLine($"The max element from array is {array[array.Length - 1]}");
            return array[array.Length - 1];
        }
    }
}
