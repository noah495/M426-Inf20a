using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            if (!mean) {
                return "Invalid List";
            } else {
                return mean;
            }
        }
    }

    public class Median
    {
        public static double GetMedian(double[] arrSource)
        {
            // Check if the array has values        
            if (arrSource == null || arrSource.Length == 0)
                throw new ArgumentException("Array empty");
        
            // Sort the array
            double[] arrSorted = (double[])arrSource.Clone();
            Array.Sort(arrSorted);
        
            // Calculate the median
            int size = arrSorted.Length; 
            int mid = size / 2;
        
            if (size % 2 != 0)
                return arrSorted[mid];
        
            dynamic value1 = arrSorted[mid];
            dynamic value2 = arrSorted[mid - 1];
            return (value1 + value2) / 2;
        }
    }
}
